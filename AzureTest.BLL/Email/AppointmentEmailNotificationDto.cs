using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VetClinic.BLL.Email
{
    public class AppointmentEmailNotificationDto 
    {
        public string DoctorEmail { get; set; }

        public string ClientEmail { get; set; }

        public string DoctorFirstName { get; set; }

        public string DoctorLastName { get; set; }

        public string ClientFirstName { get; set; }

        public string ClientLastName { get; set; }

        public string AnimalName { get; set; }

        public string AnimalType { get; set; }

        public string Date { get; set; }

        public string ServiceName { get; set; }

        public int? StatusId { get; set; }
    }
}
