using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Birbiz.WebServices.Common.Results
{
    public abstract class BaseJsonResult : JsonResult
    {
        private readonly IResultValue value;

        protected BaseJsonResult(IResultValue value, HttpStatusCode statusCode) : base(null, new LowerCaseJsonSerializerSettings())
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            this.value = value;
            StatusCode = (int)statusCode;
        }

        public override Task ExecuteResultAsync(ActionContext context)
        {
            Value = value.Execute(context);

            return base.ExecuteResultAsync(context);
        }
    }
}