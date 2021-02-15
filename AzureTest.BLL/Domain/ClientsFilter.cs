using System;
using System.Collections.Generic;
using System.Text;

namespace VetClinic.BLL.Domain
{
    public class ClientsFilter
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
