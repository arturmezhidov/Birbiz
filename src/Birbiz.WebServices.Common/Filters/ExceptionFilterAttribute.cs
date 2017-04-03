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
            context.Result = String.IsNullOrEmpty(ErrorMessage)
                ? new JsonInternalServerErrorResult(new ExceptionResultValue(context.Exception))
                : new JsonInternalServerErrorResult(new MessageResultValue(ErrorMessage, MessageType.Error));

            context.ExceptionHandled = true;
        }
    }
}