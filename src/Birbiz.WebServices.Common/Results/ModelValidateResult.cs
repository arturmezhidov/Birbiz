using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Birbiz.WebServices.Common.Results
{
    public class ModelValidateResult : ErrorResult
    {
        public override int StatusCode { get { return (int)HttpStatusCode.BadRequest; } }

        public override bool HasError { get { return Errors.Any(); } }

        public Dictionary<string, List<string>> Errors { get; set; }

        public ModelValidateResult()
        {
            Errors = new Dictionary<string, List<string>>();
        }

        public ModelValidateResult(ModelStateDictionary state) : this()
        {
            if (state == null)
            {
                throw new ArgumentNullException(nameof(state));
            }

            foreach (KeyValuePair<string, ModelStateEntry> entry in state)
            {
                Errors.Add(
                    entry.Key, 
                    entry.Value.Errors.Select(error => error.ErrorMessage).ToList()
                );
            }
        }
    }
}