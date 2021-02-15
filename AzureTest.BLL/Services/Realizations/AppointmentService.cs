using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;
using VetClinic.BLL.Domain;
using VetClinic.BLL.Exceptions;
using VetClinic.BLL.Helpers;
using VetClinic.BLL.Services.Interfaces;
using VetClinic.DAL.Entities;
using VetClinic.DAL.Repositories.Interfaces;

namespace VetClinic.BLL.Services.Realizations
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryWrapper _repositoryWrapper;

        public AppointmentService(IMapper mapper, IRepositoryWrapper repositoryWrapper)
        {
            _mapper = mapper;
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<ICollection<Appointment>> GetAllAppointmentsAsync(
            AppointmentsFilter filter = null,
            PaginationFilter pagination = null)
        {
            if (pagination != null && filter != null)
            {
                return await _repositoryWrapper.AppointmentRepository.GetAsync(Filter(filter), Include(), OrderBy(pagination),
                    pagination.PageNumber, pagination.PageSize);
            }

            if (filter != null)
            {
                return await _repositoryWrapper.AppointmentRepository.GetAsync(Filter(filter), Include());
            }

            if (pagination != null)
            {
                return await _repositoryWrapper.AppointmentRepository.GetAsync(include: Include(), orderBy: OrderBy(pagination),
                    pageNumber: pagination.PageNumber, pageSize: pagination.PageSize);
            }

            return await _repositoryWrapper.AppointmentRepository.GetAsync(include: Include());
        }

        public async Task<Appointment> GetAppointmentByIdAsync(int id)
        {
            var appointment = await _repositoryWrapper.AppointmentRepository.GetFirstOrDefaultAsync(a => a.Id == id, Include());
            if (appointment == null)
                throw new VetClinicException(HttpStatusCode.NotFound, $"Appointment with id {id} doesn't exist");

            return appointment;
        }

        public async Task<Appointment> CreateAppointmentAsync(Appointment appointment)
        {
            _repositoryWrapper.AppointmentRepository.Add(appointment);
            await _repositoryWrapper.SaveAsync();

            var createdAppointment = await GetAppointmentByIdAsync(appointment.Id);

            return createdAppointment;
        }

        public async Task<Appointment> UpdateAppointmentAsync(int id, Appointment appointment)
        {
            var appointmentToUpdate = await GetAppointmentByIdAsync(id);

            UpdatePerformedProcedures(appointment, appointmentToUpdate);
            _mapper.Map(appointment, appointmentToUpdate);

            _repositoryWrapper.AppointmentRepository.Update(appointmentToUpdate);
            await _repositoryWrapper.SaveAsync();

            appointmentToUpdate = await GetAppointmentByIdAsync(id);

            return appointmentToUpdate;
        }

        public async Task<Appointment> DeleteAppointmentAsync(int id)
        {
            var appointment = await GetAppointmentByIdAsync(id);

            _repositoryWrapper.AppointmentRepository.Remove(appointment);
            await _repositoryWrapper.SaveAsync();

            return appointment;
        }

        public async Task<int> GetTotalCount(AppointmentsFilter filter = null)
        {
           return await _repositoryWrapper.AppointmentRepository.CountAsync(Filter(filter));
        }

        private void UpdatePerformedProcedures(Appointment source, Appointment destination)
        {
            foreach (var ap in destination.AppointmentProcedures)
            {
                _repositoryWrapper.AppointmentProceduresRepository.Remove(ap);
            }

            foreach (var ap in source.AppointmentProcedures)
            {
                ap.AppointmentId = destination.Id;
                _repositoryWrapper.AppointmentProceduresRepository.Add(ap);
            }
        }

        private static Func<IQueryable<Appointment>, IIncludableQueryable<Appointment, object>> Include()
        {
            return app => app
                .Include(a => a.Animal).ThenInclude(a => a.AnimalType)
                .Include(a => a.Animal).ThenInclude(a => a.Client).ThenInclude(c => c.User)
                .Include(a => a.Service)
                .Include(a => a.Status)
                .Include(a => a.Doctor).ThenInclude(d => d.User)
                .Include(a => a.AppointmentProcedures).ThenInclude(a => a.Procedure);
        }

        private static Expression<Func<Appointment, bool>> Filter(AppointmentsFilter filter)
        {
            var expressionsList = new List<Expression<Func<Appointment, bool>>>();

            if (filter.StatusId != null)
            {
                Expression<Func<Appointment, bool>> statusFilter = a => a.StatusId == filter.StatusId;
                expressionsList.Add(statusFilter);
            }

            if (filter.ServiceId != null)
            {
                Expression<Func<Appointment, bool>> serviceFilter = a => a.ServiceId == filter.ServiceId;
                expressionsList.Add(serviceFilter);
            }

            if (filter.DoctorId != null)
            {
                Expression<Func<Appointment, bool>> doctorFilter = a => a.DoctorId == filter.DoctorId;
                expressionsList.Add(doctorFilter);
            }

            if (filter.AnimalId != null)
            {
                Expression<Func<Appointment, bool>> animalFilter = a => a.AnimalId == filter.AnimalId;
                expressionsList.Add(animalFilter);
            }

            if (filter.ClientId != null)
            {
                Expression<Func<Appointment, bool>> clientFilter = a => a.Animal.ClientId == filter.ClientId;
                expressionsList.Add(clientFilter);
            }

            Expression<Func<Appointment, bool>> expression = appointment => true;

            foreach (var exp in expressionsList)
            {
                expression = expression.AndAlso(exp);
            }

            return expression;
        }

        private static Func<IQueryable<Appointment>, IOrderedQueryable<Appointment>> OrderBy(PaginationFilter filter)
        {
            Func<IQueryable<Appointment>, IOrderedQueryable<Appointment>> orderBy;
            switch (filter.OrderBy)
            {
                case "date":
                    orderBy = apps => apps.OrderBy(a => a.AppointmentDate);
                    break;
                case "date_desc":
                    orderBy = apps => apps.OrderByDescending(a => a.AppointmentDate);
                    break;
                default:
                    orderBy = apps => apps.OrderBy(a => a.Id);
                    break;
            }

            return orderBy;
        }
    }
}