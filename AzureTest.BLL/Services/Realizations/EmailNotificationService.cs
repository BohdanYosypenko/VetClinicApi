using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using VetClinic.BLL.Domain;
using VetClinic.BLL.Email;
using VetClinic.BLL.Services.Interfaces;
using VetClinic.DAL.Entities;
using System.Linq;

namespace VetClinic.BLL.Services.Realizations
{
    public class EmailNotificationService : IEmailNotificationService
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IClientService _clientService;
        private readonly IDoctorService _doctorService;
        private readonly IServiceService _serviceService;

        public EmailNotificationService(IAppointmentService appointmentService,
            IClientService clientService, IDoctorService doctorService,
            IServiceService serviceService)
        {
            _appointmentService = appointmentService;
            _clientService = clientService;
            _doctorService = doctorService;
            _serviceService = serviceService;
        }

        public async Task<bool> SendEmailAsync(EmailModel emailModel)
        {
            bool isSend = false;
            MailMessage mailMessage = CreateMailMessageObject(emailModel);
            try
            {
                await EmailHelper.smtp.SendMailAsync(mailMessage);
                isSend = true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return isSend;
        }

        public MailMessage CreateMailMessageObject(EmailModel email)
        {
            var body = email.Message;
            var mailMessage = new MailMessage();

            foreach (string emailTo in email.EmailsTo)
                mailMessage.To.Add(new MailAddress(emailTo));

            mailMessage.From = new MailAddress(EmailHelper.EmailInfo.EmailSender);
            mailMessage.Subject = email.Subject;
            mailMessage.Body = body;
            mailMessage.IsBodyHtml = true;

            if (email.FileNameAttachments != null)
            {
                mailMessage.AddAttachments(email.FileNameAttachments);
            }

            if (email.StreamAttachments != null)
            {
                mailMessage.AddAttachments(email.StreamAttachments);
            }

            return mailMessage;
        }

        //appointment
        public async Task SendAppointmentNotifications(int appointmentId)
        {
            Appointment appointment = await _appointmentService.GetAppointmentByIdAsync(appointmentId);
            if (appointment != null)
            {
                AppointmentEmailNotificationDto dto = CreateAppointmentNotificationDto(appointment);

                await SendAppointmentNotificationDoctor(dto);
                await SendAppointmentNotificationClient(dto);
            }
        }

        public AppointmentEmailNotificationDto CreateAppointmentNotificationDto(Appointment appointment)
        {
            if (appointment != null)
            {
                AppointmentEmailNotificationDto dto = new AppointmentEmailNotificationDto
                {
                    DoctorEmail = appointment?.Doctor?.User?.Email,
                    DoctorFirstName = appointment?.Doctor?.User?.FirstName,
                    DoctorLastName = appointment?.Doctor?.User?.LastName,
                    ClientEmail = appointment?.Animal?.Client?.User?.Email,
                    ClientFirstName = appointment?.Animal?.Client?.User?.FirstName,
                    ClientLastName = appointment?.Animal?.Client?.User?.LastName,
                    AnimalName = appointment?.Animal?.Name,
                    AnimalType = appointment?.Animal?.AnimalType?.AnimalTypeName,
                    Date = appointment?.AppointmentDate.ToString(),
                    ServiceName = appointment?.Service?.ServiceName,
                    StatusId = appointment?.StatusId
                };
                return dto;
            }
            else return null;
        }

        public async Task SendAppointmentNotificationDoctor(AppointmentEmailNotificationDto dto)
        {
            string emailTo = dto.DoctorEmail;
            if (emailTo != null)
            {
                EmailModel email = new EmailModel
                {
                    EmailsTo = new List<string> { emailTo },
                    Subject = EmailHelper.AppointmentDoctorSubject,
                    Message = EmailHelper.AppointmentDoctorMessage(dto)
                };
                await SendEmailAsync(email);
            }
        }

        public async Task SendAppointmentNotificationClient(AppointmentEmailNotificationDto dto)
        {
            string emailTo = dto.ClientEmail;
            if (emailTo != null)
            {
                EmailModel email = new EmailModel
                {
                    EmailsTo = new List<string> { emailTo },
                    Subject = EmailHelper.AppointmentClientSubject,
                    Message = EmailHelper.AppointmentClientMessage(dto)
                };
                await SendEmailAsync(email);
            }
        }

        public async Task SendClientAppointmentsInvoice(int clientId, byte[] fileBytes)
        {
            Client client = await _clientService.GetClient(clientId);
            if (client != null)
            {
                string clientEmail = client.User.Email;

                //CreateStreamAttachment, depending on appointment
                StreamAttachment streamAttach = new StreamAttachment();
                streamAttach.Stream = new System.IO.MemoryStream(fileBytes);
                streamAttach.FileName = "Appointment_Invoice.pdf";

                EmailModel email = new EmailModel
                {
                    EmailsTo = new List<string> { clientEmail },
                    Subject = EmailHelper.AppointmentInvoiceSubject,
                    Message = EmailHelper.AppointmentInvoiceMessage(client.User.UserName),
                    StreamAttachments = new List<StreamAttachment> { streamAttach }
                };
                await SendEmailAsync(email);
            }
        }

        //registration
        public async Task SendClientRegistrationNotification(string username)
        {
            ClientsFilter filter = new ClientsFilter { UserName = username };
            Client client = _clientService.GetAllClients(filter).Result.FirstOrDefault();
            User user = client?.User;
            if (user != null)
            {
                string emailTo = user.Email;
                if (emailTo != null)
                {
                    EmailModel email = new EmailModel
                    {
                        EmailsTo = new List<string> { emailTo },
                        Subject = EmailHelper.RegistrationSubject,
                        Message = EmailHelper.RegistrationMessage(user.FirstName, user.LastName)
                    };
                    await SendEmailAsync(email);
                }
            }
        }

        //service

        public async Task SendNewServiceNotification(int serviceId)
        {
            Service service = await _serviceService.GetServiceByIdAsync(serviceId);
            if (service != null)
            {
                EmailModel email = new EmailModel
                {
                    Subject = EmailHelper.ServiceSubject,
                    Message = EmailHelper.ServiceMessage(service.ServiceName, service.Description)
                };
                await SendNotificationToAllClients(email);
            }
        }

        //

        //multiple sending
        public async Task SendNotificationToAllClients(EmailModel email)
        {
            email.EmailsTo = await _clientService.GetAllClientsEmails();
            await SendEmailAsync(email);
        }

        public async Task SendNotificationToAllDoctors(EmailModel email)
        {
            email.EmailsTo = await _doctorService.GetAllDoctorsEmails();
            await SendEmailAsync(email);
        }

        public async Task SendNotificationToAllUsers(EmailModel email)
        {
            await SendNotificationToAllClients(email);
            await SendNotificationToAllDoctors(email);
        }

        public async Task SendNotificationToUsers(IEnumerable<User> users, EmailModel email)
        {
            foreach (User user in users)
                await SendEmailAsync(email);
        }
    }
}

