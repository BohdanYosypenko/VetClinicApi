using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetClinic.API.DTO.Accountant
{
    public class CreateInvoiceDto
    {
        public int ClientId { get; set; }
        public int AppointmentId { get; set; }
    }
}
