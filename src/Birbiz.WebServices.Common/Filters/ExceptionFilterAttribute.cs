using System;
using Birbiz.WebServices.Common.Results;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Birbiz.WebServices.Common.Filters
{
    public class ExceptionFilterAttribute : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            context.Result = new JsonActionResult(new ExceptionResult(context.Exception));

            context.ExceptionHandled = true;
        }
    }
}