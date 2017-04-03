using System;
using Microsoft.AspNetCore.Mvc;

namespace Birbiz.WebServices.Common.Results
{
    public class ExceptionResultValue : ErrorResultValue
    {
        private readonly Exception exception;

        public ExceptionResultValue(Exception exception)
        {
            if (exception == null)
            {
                throw new ArgumentNullException(nameof(exception));
            }

            this.exception = exception;
        }

        protected override void OnExecuting(ActionContext context)
        {
            Add(exception.Source, exception.Message);
        }
    }
}