using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VetClinic.BLL.Email;
using VetClinic.DAL.Entities;

namespace VetClinic.BLL.Services.Interfaces
{
    public interface IEmailNotificationService
    {       
        public Task<bool> SendEmailAsync(EmailModel email);
        public Task SendAppointmentNotifications(int appointmentId);

        public Task SendClientRegistrationNotification(string username);

        public Task SendNotificationToAllUsers(EmailModel email);

        public Task SendNewServiceNotification(int serviceId);

        public Task SendClientAppointmentsInvoice(int clientId, byte[] fileBytes);

    }
}

