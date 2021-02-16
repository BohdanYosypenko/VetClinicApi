using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VetClinic.API.DTO.Accountant;
using VetClinic.BLL.Email;
using VetClinic.BLL.Services.Interfaces;

namespace VetClinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailNotificationsController : ControllerBase
    {
        private readonly IEmailNotificationService _emailNotificationService;
        private readonly IFinancialReportService _financialReportService;

        public EmailNotificationsController(IEmailNotificationService emailNotificationService, IFinancialReportService financialReportService)
        {
            _emailNotificationService = emailNotificationService;
            _financialReportService = financialReportService;
        }


        [HttpGet("appointments/{appointmentId}")]
        public async Task<IActionResult> SendAppointmentNotification(int appointmentId)
        {
            await _emailNotificationService.SendAppointmentNotifications(appointmentId);
            return NoContent();
        }

        [HttpPost("appointments/invoice")]
        public async Task<IActionResult> SendAppointmentsInvoice([FromBody] CreateInvoiceDto invoiceDto)
        {
            var invoiceModel = await _financialReportService.CreateInvoiceReportModel(invoiceDto.ClientId, invoiceDto.AppointmentId);

            byte[] invoiceReport = await _financialReportService.GenerateInvoice(invoiceModel);

            await _emailNotificationService.SendClientAppointmentsInvoice(invoiceDto.ClientId, invoiceReport);
            return NoContent();
        }

        [HttpGet("registration/{username}")]
        public async Task<IActionResult> SendRegistrationNotification(string username)
        {
            await _emailNotificationService.SendClientRegistrationNotification(username);
            return NoContent();
        }

        [HttpGet("services/{serviceId}")]
        public async Task<IActionResult> SendNewServiceNotification(int serviceId)
        {
            await _emailNotificationService.SendNewServiceNotification(serviceId);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> SendWrittenNotification(string subject, string message)
        {
            EmailModel email = new EmailModel
            {
                Subject = subject,
                Message = message
            };
            await _emailNotificationService.SendNotificationToAllUsers(email);
            return NoContent();
        }

    }
}
