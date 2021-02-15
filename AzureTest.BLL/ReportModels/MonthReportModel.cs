using System.Collections.Generic;

namespace VetClinic.BLL.ReportModels
{
    public class MonthReportModel
    {
        public string Month { get; set; }
        public string Year { get; set; }
        public List<PerformedProceduresReportModel> Procedures { get; set; }
        public List<DoctorReportModel> Doctors { get; set; }
        public decimal? RentExpense { get; set; }
        public decimal? AdvertisingExpense { get; set; }
        public decimal? UtilitiesExpense { get; set; }
    }
}
