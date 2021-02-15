using System;
using System.Net;

namespace VetClinic.BLL.Exceptions
{
    public class VetClinicException : Exception
    {
        public HttpStatusCode Status { get; set; }
        public FieldErrorModel[] Errors { get; set; }

        public VetClinicException(HttpStatusCode status, string msg, params FieldErrorModel[] fieldErrors) : base(msg)
        {
            Status = status;
            Errors = fieldErrors;
        }
    }
}