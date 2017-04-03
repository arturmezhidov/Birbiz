using System.Net;

namespace Birbiz.WebServices.Common.Results
{
    public class JsonBadRequestResult : BaseJsonResult
    {
        public JsonBadRequestResult(IResultValue value) : base(value, HttpStatusCode.BadRequest)
        {
        }
    }
}