using System;
using Birbiz.WebServices.Common.Results;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Birbiz.WebServices.Common.Filters
{
    public class ExceptionFilterAttribute : Attribute, IExceptionFilter
    {
        public string ErrorMessage { get; set; }

        public ExceptionFilterAttribute()
        {
        }

        public ExceptionFilterAttribute(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public void OnException(ExceptionContext context)
        {
            InternalServerError error = String.IsNullOrEmpty(ErrorMessage)
                ? new InternalServerError(context.Exception)
                : new InternalServerError(ErrorMessage);

            context.Result = new JsonActionResult(error);

            context.ExceptionHandled = true;
        }
    }
}