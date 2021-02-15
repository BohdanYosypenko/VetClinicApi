using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Threading.Tasks;
using VetClinic.API.DTO.Error;
using VetClinic.BLL.Exceptions;

namespace VetClinic.API.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            int statusCode = 500;

            var errorDto = new ErrorDto
            {
                Status = statusCode,
                Title = "Something went wrong",
                Errors = new FieldErrorModel[] { }
            };

            if (ex is VetClinicException httpException)
            {
                statusCode = (int) httpException.Status;
                errorDto = new ErrorDto
                {
                    Status = statusCode,
                    Title = httpException.Message,
                    Errors = httpException.Errors
                };
            }


            context.Response.ContentType = "application/json";
            context.Response.StatusCode = statusCode;

            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            string json = JsonConvert.SerializeObject(errorDto, settings);

            return context.Response.WriteAsync(json);
        }
    }
}