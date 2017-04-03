using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Birbiz.WebServices.Common.Results
{
    public class ErrorResultValue : IResultValue
    {
        public Dictionary<string, string> Errors { get; set; }

        protected ErrorResultValue()
        {
            Errors = new Dictionary<string, string>();
        }

        protected ErrorResultValue(string key, string errorMessage) : this()
        {
            Add(key, errorMessage);
        }

        public void Add(string key, string errorMessage)
        {
            Errors.Add(key, errorMessage);
        }

        public object Execute(ActionContext context)
        {
            OnExecuting(context);

            return this;
        }

        protected virtual void OnExecuting(ActionContext context)
        {
        }
    }
}