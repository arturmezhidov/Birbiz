using System.Net;
using Birbiz.WebServices.Common.Results;

namespace Birbiz.WebServices.Auth.Results
{
    public class RegisterResult : BaseResult
    {
        public override bool IsSuccess { get { return true; } }

        public override bool HasError { get { return false; } }

        public RegisterResult() : base((int)HttpStatusCode.OK)
        {
        }
    }
}