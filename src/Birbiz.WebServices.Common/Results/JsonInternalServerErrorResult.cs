using System.Net;

namespace Birbiz.WebServices.Common.Results
{
    public class JsonInternalServerErrorResult : BaseJsonResult
    {
        public JsonInternalServerErrorResult(IResultValue value) : base(value, HttpStatusCode.InternalServerError)
        {
        }
    }
}