using VetClinic.DAL.Entities;
using VetClinic.DAL.Repositories.Interfaces;

namespace VetClinic.DAL.Repositories.Realizations
{
    public class AppointmentRepository : RepositoryBase<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(ApplicationContext context) : base(context) { }
    }
}