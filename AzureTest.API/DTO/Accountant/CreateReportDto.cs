using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetClinic.API.DTO.Accountant
{
    public class CreateReportDto
    {
        public DateTime DateReport { get; set; }
        public decimal RentExpense { get; set; }
        public decimal AdvertisingExpense { get; set; }
        public decimal UtilitiesExpense { get; set; }
    }
}
