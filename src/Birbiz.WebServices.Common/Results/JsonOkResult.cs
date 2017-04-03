using System.Net;

namespace Birbiz.WebServices.Common.Results
{
    public class JsonOkResult : BaseJsonResult
    {
        public JsonOkResult(IResultValue value) : base(value, HttpStatusCode.OK)
        {
        }
    }
}