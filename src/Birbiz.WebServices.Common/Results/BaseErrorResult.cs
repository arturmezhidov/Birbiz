using System.Collections.Generic;
using System.Linq;

namespace Birbiz.WebServices.Common.Results
{
    public abstract class BaseErrorResult : BaseResult
    {
        public override bool IsSuccess { get { return false; } }

        public override bool HasError { get { return Errors.Any(); } }

        public Dictionary<string, string> Errors { get; set; }

        protected BaseErrorResult(int statusCode) : base(statusCode)
        {
            Errors = new Dictionary<string, string>();
        }

        public void Add(string key, string errorMessage)
        {
            Errors.Add(key, errorMessage);
        }
    }
}