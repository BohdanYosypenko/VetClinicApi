using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VetClinic.BLL.Email
{
    public class StreamAttachment
    {
        public MemoryStream Stream { get; set; }
        public string FileName { get; set; }
    }
}
