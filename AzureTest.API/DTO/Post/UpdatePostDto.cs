using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetClinic.API.DTO.Post
{
    public class UpdatePostDto
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string MainText { get; set; }
        public string Photo { get; set; }
    }
}
