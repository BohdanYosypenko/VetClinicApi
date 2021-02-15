using System.Collections.Generic;

namespace VetClinic.BLL.ReportModels
{
    public class InvoiceReportModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public string InvoiceDate { get; set; }
        public string InvoiceDueDate { get; set; }

        public List<ProcedureInvoiceModel> Procedures { get; set; }
    }
}
