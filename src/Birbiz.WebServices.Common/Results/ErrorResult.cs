using System.Net;

namespace Birbiz.WebServices.Common.Results
{
    public abstract class ErrorResult : BaseResult
    {
        public override bool IsSuccess { get { return false; } }

        public override int StatusCode { get { return (int)HttpStatusCode.BadRequest; } }
    }
}