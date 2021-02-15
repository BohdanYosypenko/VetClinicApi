using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetClinic.BLL.ReportModels;
using VetClinic.BLL.Services.Interfaces;
using VetClinic.DAL.Repositories.Interfaces;

namespace VetClinic.BLL.Services.Realizations
{
    public class FinancialReportService : IFinancialReportService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public FinancialReportService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<byte[]> SaveExcelReportFile(MonthReportModel model)
        {           
            using (var package = new ExcelPackage())
            {
                var workSheet = package.Workbook.Worksheets.Add($"{model.Month} , {model.Year}");

                workSheet.Cells.Style.Font.Size = 14;

                workSheet.Cells["A1"].Value = "VETERINARY CLINIC";
                workSheet.Cells["A1:D1"].Merge = true;
                workSheet.Row(1).Style.Font.Bold = true;
                workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                workSheet.Cells["A2"].Value = "Income statement";
                workSheet.Cells["A2:D2"].Merge = true;
                workSheet.Row(2).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                workSheet.Cells["A3"].Value = $"For the month ended {model.Month} , {model.Year}";
                workSheet.Cells["A3:D3"].Merge = true;
                workSheet.Row(3).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                workSheet.Cells["A3:D3"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;

                workSheet.Cells["A4"].Value = "Revenues";
                workSheet.Cells["A4:D4"].Merge = true;
                workSheet.Row(4).Style.Font.Bold = true;

                int proceduresCount = 0;
                if (model.Procedures != null && model.Procedures.Count > 0)
                {
                    for (int i = 1; i <= model.Procedures.Count; i++)
                    {
                        workSheet.Cells["B" + (4 + i).ToString()].Value = $"{model.Procedures[i - 1].ProcedureName}: ({model.Procedures[i - 1].Count})";
                        workSheet.Cells["C" + (4 + i).ToString()].Value = model.Procedures[i - 1].Price * model.Procedures[i - 1].Count;

                        proceduresCount++;
                    }
                }

                workSheet.Cells["C" + (5 + proceduresCount).ToString()].Value = "Service revenue";
                if (proceduresCount > 0)
                {
                    workSheet.Cells["D" + (5 + proceduresCount).ToString()].Formula = "=SUM(C5:C" + (5 + proceduresCount - 1).ToString() + ")";
                }
                else
                {
                    workSheet.Cells["D" + (5 + proceduresCount).ToString()].Value = 0;
                }
                workSheet.Cells["D" + (5 + proceduresCount).ToString()].Style.Font.Bold = true;

                workSheet.Cells["A" + (6 + proceduresCount).ToString()].Value = "Expenses";
                workSheet.Cells["A" + (6 + proceduresCount).ToString() + ":D" + (6 + proceduresCount).ToString()].Merge = true;
                workSheet.Row(6 + proceduresCount).Style.Font.Bold = true;

                int employeeCount = 0;
                if (model.Doctors != null && model.Doctors.Count > 0)
                {
                    for (int i = 1; i <= model.Doctors.Count; i++)
                    {
                        workSheet.Cells["B" + (6 + (proceduresCount + i)).ToString()].Value = $"{model.Doctors[i - 1].FirstName} {model.Doctors[i - 1].LastName}";
                        workSheet.Cells["C" + (6 + (proceduresCount + i)).ToString()].Value = model.Doctors[i - 1].Salary;

                        employeeCount++;
                    }
                }

                workSheet.Cells["B" + (7 + proceduresCount + employeeCount).ToString()].Value = "Salaries expense";
                if (employeeCount > 0)
                {
                    workSheet.Cells["C" + (7 + proceduresCount + employeeCount).ToString()].Formula = "=SUM(C" + (7 + proceduresCount).ToString() + ":C" + (6 + proceduresCount + employeeCount).ToString() + ")";
                }
                else
                {
                    workSheet.Cells["C" + (7 + proceduresCount + employeeCount).ToString()].Value = 0;
                }
                workSheet.Cells["C" + (7 + proceduresCount + employeeCount).ToString()].Style.Font.Bold = true;

                int totalCount = proceduresCount + employeeCount;

                workSheet.Cells["B" + (8 + totalCount).ToString()].Value = "Rent expense";
                workSheet.Cells["C" + (8 + totalCount).ToString()].Value = model.RentExpense != null ? model.RentExpense : 0;
                workSheet.Cells["C" + (8 + totalCount).ToString()].Style.Font.Bold = true;

                workSheet.Cells["B" + (9 + totalCount).ToString()].Value = "Advertising expense";
                workSheet.Cells["C" + (9 + totalCount).ToString()].Value = model.AdvertisingExpense != null ? model.AdvertisingExpense : 0;
                workSheet.Cells["C" + (9 + totalCount).ToString()].Style.Font.Bold = true;

                workSheet.Cells["B" + (10 + totalCount).ToString()].Value = "Utilities expense";
                workSheet.Cells["C" + (10 + totalCount).ToString()].Value = model.UtilitiesExpense != null ? model.UtilitiesExpense : 0;
                workSheet.Cells["C" + (10 + totalCount).ToString()].Style.Font.Bold = true;

                workSheet.Cells["C" + (11 + totalCount).ToString()].Value = "Total expense";
                workSheet.Cells["D" + (11 + totalCount).ToString()].Formula = "=SUM(C" + (7 + totalCount).ToString() + ":C" + (10 + totalCount).ToString() + ")";
                workSheet.Cells["D" + (11 + totalCount).ToString()].Style.Font.Bold = true;

                workSheet.Cells["A" + (12 + totalCount).ToString()].Value = "Net income";
                workSheet.Cells["A" + (12 + totalCount).ToString() + ":" + "C" + (12 + totalCount).ToString()].Merge = true;
                workSheet.Cells["A" + (12 + totalCount).ToString()].Style.Font.Bold = true;
                workSheet.Cells["D" + (12 + totalCount).ToString()].Formula = "=D" + (5 + proceduresCount).ToString() + "-D" + (11 + totalCount).ToString();
                workSheet.Cells["D" + (12 + totalCount).ToString()].Style.Font.Bold = true;
                workSheet.Cells["D" + (12 + totalCount).ToString()].Style.Border.BorderAround(ExcelBorderStyle.Thin);

                ExcelRange rg = workSheet.Cells[1, 1, workSheet.Dimension.End.Row, workSheet.Dimension.End.Column];
                rg.Style.Border.BorderAround(ExcelBorderStyle.Thick);

                double minimumSize = 12;
                workSheet.Cells[workSheet.Dimension.Address].AutoFitColumns(minimumSize);

                return await package.GetAsByteArrayAsync();
            }
        }

        public  async Task<byte[]> GenerateInvoice(InvoiceReportModel model)
        {
            using (var package = new ExcelPackage())
            {
                var workSheet = package.Workbook.Worksheets.Add($"Invoice: {model.InvoiceDate}");
                workSheet.Cells.Style.Font.Size = 14;

                ExcelRange rg = workSheet.Cells[1, 1, 6, 7];
                rg.Style.Fill.PatternType = ExcelFillStyle.Solid;
                rg.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.YellowGreen);

                workSheet.Cells["B5"].Value = "Invoice";
                workSheet.Cells["B5"].Style.Font.Size = 28;
                workSheet.Cells["B5"].Style.Font.Color.SetColor(System.Drawing.Color.White);

                workSheet.Cells["F1"].Value = "Veterinary clinic";
                workSheet.Cells["F2"].Value = "7 Galycka street";
                workSheet.Cells["F3"].Value = "Ivano-Frankivsk";
                workSheet.Cells["F4"].Value = "Ukraine";
                workSheet.Cells["F5"].Value = "564-555-1234";
                workSheet.Cells["F1:F5"].Style.Font.Color.SetColor(System.Drawing.Color.White);
                workSheet.Cells["F1:F5"].Style.Font.Size = 14;

                workSheet.Cells["B7"].Value = "Bill to:";
                workSheet.Cells["B8"].Value = $"{model.FirstName}  {model.LastName}";
                workSheet.Cells["B9"].Value = model.PhoneNumber;
                workSheet.Cells["B10"].Value = model.EmailAddress;

                workSheet.Cells["F7"].Value = "DATE";
                workSheet.Row(7).Style.Font.Bold = true;
                workSheet.Cells["F8"].Value = model.InvoiceDate;
                workSheet.Cells["F9"].Value = "INVOICE DUE DATE";
                workSheet.Cells["F10"].Value = model.InvoiceDueDate;
                workSheet.Cells["F11"].Value = "1234-5678-9012-3456";
                workSheet.Cells["F11"].Style.Font.Size = 14;
                workSheet.Cells["A11:G11"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;

                workSheet.Cells["B12"].Value = "Performed procedures:";
                workSheet.Cells["D12"].Value = "Description";
                workSheet.Cells["F12"].Value = "PRICE";
                workSheet.Row(12).Style.Font.Bold = true;

                int procedureCount = 0;
                if (model.Procedures != null && model.Procedures.Count > 0)
                {
                    for (int i = 1; i <= model.Procedures.Count; i++)
                    {
                        workSheet.Cells["B" + (12 + i).ToString()].Value = $"{model.Procedures[i - 1].Name}";
                        workSheet.Cells["D" + (12 + i).ToString()].Value = $"{model.Procedures[i - 1].Description}";
                        workSheet.Cells["F" + (12 + i).ToString()].Value = $"{model.Procedures[i - 1].Price}";
                        workSheet.Row(12 + i).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        workSheet.Row(12 + i).Style.Font.Size = 12;
                        procedureCount++;
                    }
                }

                workSheet.Cells["A" + (12 + procedureCount).ToString() + ":G" + (12 + procedureCount).ToString()].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;

                workSheet.Cells["F" + (13 + procedureCount).ToString()].Value = "Total:";
                workSheet.Cells["F" + (14 + procedureCount).ToString()].Value = (model.Procedures != null && model.Procedures.Count > 0) ? model.Procedures.Sum(p => p.Price) : 0;
                workSheet.Cells["F" + (14 + procedureCount).ToString()].Style.Font.Bold = true;

                workSheet.Cells["F1:F" + (14 + procedureCount).ToString()].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;


                ExcelRange excelRange = workSheet.Cells[1, 1, workSheet.Dimension.End.Row, workSheet.Dimension.End.Column];
                excelRange.Style.Border.BorderAround(ExcelBorderStyle.Thick);

                double minimumSize = 7;
                workSheet.Cells[workSheet.Dimension.Address].AutoFitColumns(minimumSize);

                workSheet.Column(4).AutoFit(20, 60);
                workSheet.Column(4).Style.WrapText = true;

                byte[] excelFile = await package.GetAsByteArrayAsync();
                SautinSoft.ExcelToPdf x = new SautinSoft.ExcelToPdf();               
                return x.ConvertBytes(excelFile);
            }
        }

        public async Task<InvoiceReportModel> CreateInvoiceReportModel(int clientId, int appointmentId)
        {
            var client = await _repositoryWrapper.ClientRepository.GetFirstOrDefaultAsync(include: cl => cl.Include(u => u.User), filter: cl => cl.Id == clientId);

            var appointment = await _repositoryWrapper.AppointmentRepository
                .GetFirstOrDefaultAsync(include: app => app.Include(a => a.AppointmentProcedures).ThenInclude(a => a.Procedure), filter: app => app.Id == appointmentId);

            var procedureInvoiceModels = appointment.AppointmentProcedures.Select(ap =>
                    new ProcedureInvoiceModel
                    {
                       Name =  ap.Procedure.ProcedureName,
                       Description = ap.Procedure.Description,
                       Price = ap.Procedure.Price
                    }).ToList();

            return new InvoiceReportModel
            {
                FirstName = client.User.FirstName,
                LastName = client.User.LastName,
                PhoneNumber = client.User.PhoneNumber,
                EmailAddress = client.User.Email,
                InvoiceDate = appointment.AppointmentDate.ToString("dd.MM.yyyy"),
                InvoiceDueDate = appointment.AppointmentDate.AddDays(10).ToString("dd.MM.yyyy"),
                Procedures = procedureInvoiceModels
            };
        }


        public async Task<List<DoctorReportModel>> GetDoctors()
        {
            var doctors = await _repositoryWrapper.DoctorRepository.GetAsync(include: doc => doc.Include(d => d.User).Include(d => d.Position), 
                filter: doc => !doc.User.IsDeleted);

            var doctorsReportModels = doctors.Select(u => new DoctorReportModel
                        {
                             FirstName = u.User.FirstName,
                             LastName = u.User.LastName,
                             Salary = u.Position.Salary
                        }).ToList();

            return doctorsReportModels;
        }

        public async Task<List<PerformedProceduresReportModel>> GetPerformedProcedures(DateTime date)
        {
            var filteredAppProc = await _repositoryWrapper.AppointmentProceduresRepository
                .GetAsync(include: app => app.Include(a => a.Appointment)
                .Include(a => a.Procedure),filter: app => app.Appointment.AppointmentDate.Month == date.Month && app.Appointment.StatusId == 4);

            var result = filteredAppProc.GroupBy(u => u.Procedure)
                .Select(g => new PerformedProceduresReportModel { ProcedureName = g.Key.ProcedureName, Price = g.Key.Price, Count = g.Count()}).ToList();

            return result;
        }

    }

}
