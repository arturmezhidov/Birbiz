using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Birbiz.WebServices.Common.Results
{
    public class JsonActionResult : JsonResult
    {
        public JsonActionResult(BaseResult result) : this(result, new LowerCaseJsonSerializerSettings())
        {
        }

        public JsonActionResult(BaseResult result, JsonSerializerSettings serializerSettings) : base(result, serializerSettings)
        {
            if (result == null)
            {
                throw new ArgumentNullException(nameof(result));
            }

            StatusCode = result.StatusCode;
        }
    }
}