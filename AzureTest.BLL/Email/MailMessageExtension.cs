using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Text;

namespace VetClinic.BLL.Email
{
    public static class MailMessageExtension
    {
        public static void AddAttachments(this MailMessage mailMessage, IEnumerable<string> fileNames)
        {
            if (fileNames != null)
            {
                foreach (string fileName in fileNames)
                    mailMessage.Attachments.Add(new Attachment(fileName));
            }
        }

        public static void AddAttachments(this MailMessage mailMessage, IEnumerable<StreamAttachment> streamAttachments)
        {
            if(streamAttachments != null)
            {
                foreach(StreamAttachment streamAttachment in streamAttachments)
                    mailMessage.Attachments.Add(new Attachment(streamAttachment.Stream, streamAttachment.FileName));
            }
        }
    }
}
