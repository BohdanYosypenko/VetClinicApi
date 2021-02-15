using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VetClinic.BLL.ReportModels;

namespace VetClinic.BLL.Services.Interfaces
{
    public interface IFinancialReportService
    {
        public Task<List<DoctorReportModel>> GetDoctors();

        public Task<byte[]> SaveExcelReportFile(MonthReportModel model);

        public Task<List<PerformedProceduresReportModel>> GetPerformedProcedures(DateTime date);

        public Task<InvoiceReportModel> CreateInvoiceReportModel(int clientId, int appointmentId);

        public Task<byte[]> GenerateInvoice(InvoiceReportModel model);
    }
}
