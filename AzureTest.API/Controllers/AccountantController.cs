using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Threading.Tasks;
using VetClinic.API.DTO.Accountant;
using VetClinic.BLL.ReportModels;
using VetClinic.BLL.Services.Interfaces;

namespace VetClinic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountantController : ControllerBase
    {
        private readonly IFinancialReportService _reportService;

        public AccountantController(IFinancialReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpPost]
        public async Task<IActionResult> PostReport([FromBody] CreateReportDto createReportDto)
        {       
            MonthReportModel model = new MonthReportModel 
            {
                Month = createReportDto.DateReport.ToString("MMMM", CultureInfo.CreateSpecificCulture("en-US")),
                Year = createReportDto.DateReport.Year.ToString(), 
                Procedures = await _reportService.GetPerformedProcedures(createReportDto.DateReport),
                Doctors = await _reportService.GetDoctors(), 
                RentExpense = createReportDto.RentExpense,
                AdvertisingExpense = createReportDto.AdvertisingExpense,
                UtilitiesExpense = createReportDto.UtilitiesExpense 
            };

            byte[] bin = await _reportService.SaveExcelReportFile(model);

            //clear the buffer stream
            Response.Headers.Clear();
            Response.Clear();
            //set the correct contenttype
            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            //set the correct length of the data being send
            Response.Headers.Add("content-length", bin.Length.ToString());
            //set the filename for the excel package
            Response.Headers.Add("content-disposition", "attachment; filename=\"MonthReport.xlsx\"");
            //send the byte array to the browser
            await Response.Body.WriteAsync(bin, 0, bin.Length);
            //cleanup
            await Response.CompleteAsync();

            return Ok();
        }
    }
}
