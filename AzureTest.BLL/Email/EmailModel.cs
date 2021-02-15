using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VetClinic.BLL.Email
{
    public class EmailModel
    {
        public IEnumerable<string> EmailsTo { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public IEnumerable<string> FileNameAttachments { get; set; }

        public IEnumerable<StreamAttachment> StreamAttachments { get; set; }
    }
}
