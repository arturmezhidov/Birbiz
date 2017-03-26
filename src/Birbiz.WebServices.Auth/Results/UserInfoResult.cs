using System.Net;
using Birbiz.WebServices.Common.Results;

namespace Birbiz.WebServices.Auth.Results
{
    public class UserInfoResult : BaseResult
    {
        public string UserName { get; set; }

        public UserInfoResult(string userName) : base((int)HttpStatusCode.OK)
        {
            UserName = userName;
        }
    }
}