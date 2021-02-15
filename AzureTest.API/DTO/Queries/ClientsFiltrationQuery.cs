using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetClinic.API.DTO.Queries
{
    public class ClientsFiltrationQuery
    {
        public string UserId { get; set; }

        public string UserName { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
