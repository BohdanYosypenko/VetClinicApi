using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace VetClinic.BLL.Email
{
    public static class EmailHelper
    {
        public static class EmailInfo
        {
            public readonly static string Host = "smtp.gmail.com";
            public readonly static int Port = 587;
            public readonly static string EmailSender = "vetclinicif114notification@gmail.com";
            public readonly static string Password = "Roberto!1243$";
        }

        public static readonly SmtpClient smtp =
            new SmtpClient
            {
                Credentials = new NetworkCredential
                {
                    UserName = EmailInfo.EmailSender,
                    Password = EmailInfo.Password
                },
                Host = EmailInfo.Host,
                Port = EmailInfo.Port,
                EnableSsl = true
            };


        public static readonly string RegistrationSubject = "Registration";
        public static string RegistrationMessage(string firstName, string lastName)
        {
            string message;
            message = string.Format("Dear {0} {1}, <br/>" +
                "Welcome in VetClinic <br/>" +
                "Best regards,<br/>" +
                "Clinic administration",
                firstName, lastName);
            return message;
        }

        public static readonly string AppointmentDoctorSubject = "You have new appointment";

        public static string AppointmentDoctorMessage(AppointmentEmailNotificationDto dto)
        {
            string message;
            message = string.Format("Dear {0} {1}, <br/>" +
                "You have a new appointment with client {2} {3} for {4} " +
                "his {5} {6}.<br/> Appointment scheduled at {7} <br/>" +
                "Best regards, <br/>" +
                "Clinic administration",
                dto.DoctorFirstName, dto.DoctorLastName,
                dto.ClientFirstName, dto.ClientLastName,
                dto.ServiceName, dto.AnimalType,
                dto.AnimalName, dto.Date);
            return message;
        }

        public static readonly string AppointmentClientSubject = "You have new appointment";

        public static string AppointmentClientMessage(AppointmentEmailNotificationDto dto)
        {
            string message;
            message = string.Format("Dear {0} {1} , <br/>" +
                "You have a new appointment with doctor {2} {3} for {4}  " +
                "your {5} {6}.<br/> Appointment scheduled at {7} <br/>" +
                "Best regards,<br/>" +
                "Clinic administration",
                 dto.ClientFirstName, dto.ClientLastName,
                 dto.DoctorFirstName, dto.DoctorLastName,
                 dto.ServiceName,dto.AnimalType,
                 dto.AnimalName, dto.Date);
            return message;
        }

        public static readonly string ServiceSubject = "New service added";

        public static string ServiceMessage(string serviceName, string serviceDescription)
        {
            string message;
            message = string.Format("Dear customer, <br/>" +
                "We have a new service {0}.<br/>" +
                "Description: {1} <br/> " +
                "Best regards,<br/>" +
                "Clinic administration", serviceName, serviceDescription);
            return message;
        }

        public static readonly string AppointmentInvoiceSubject = "Invoice";

        public static string AppointmentInvoiceMessage(string userName)
        {
            string message;
            message = string.Format("Dear {0} , <br/>" +
                "Here is your invoice for all completed procedures in appointment.<br/>" +
                "Best regards, <br/>" +
                "Clinic administration", userName);
            return message;
        }

    }
}
