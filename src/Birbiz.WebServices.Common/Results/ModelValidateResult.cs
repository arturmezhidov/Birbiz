﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Birbiz.WebServices.Common.Results
{
    public class ModelValidateResult : BaseErrorResult
    {
        public ModelValidateResult() : base((int)HttpStatusCode.BadRequest)
        {

        }

        public ModelValidateResult(ModelStateDictionary state) : this()
        {
            if (state == null)
            {
                throw new ArgumentNullException(nameof(state));
            }

            foreach (KeyValuePair<string, ModelStateEntry> entry in state)
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