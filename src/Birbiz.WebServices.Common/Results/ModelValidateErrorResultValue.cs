using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Birbiz.WebServices.Common.Results
{
    public class ModelValidateErrorResultValue : ErrorResultValue
    {
        protected override void OnExecuting(ActionContext context)
        {
            foreach (KeyValuePair<string, ModelStateEntry> entry in context.ModelState)
            {
                if (entry.Value.Errors.Any())
                {
                    ModelError error = entry.Value.Errors.FirstOrDefault();

                    if (error != null)
                    {
                        Add(entry.Key, error.ErrorMessage);
                    }
                }
            }
        }
    }
}