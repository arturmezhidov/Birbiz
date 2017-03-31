using System.Net;
using Birbiz.WebServices.Common.Results;

namespace Birbiz.WebServices.Auth.Results
{
    public class RegisterResult : BaseSuccessResult
    {
        public RegisterResult() : base((int)HttpStatusCode.OK)
        {
        }
    }
}