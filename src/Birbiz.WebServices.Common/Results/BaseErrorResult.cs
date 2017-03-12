using System.Collections.Generic;
using System.Linq;

namespace Birbiz.WebServices.Common.Results
{
    public abstract class BaseErrorResult : BaseResult
    {
        public override bool IsSuccess { get { return false; } }

        public virtual bool HasError { get { return Errors.Any(); } }

        public Dictionary<string, List<string>> Errors { get; set; }

        protected BaseErrorResult(int statusCode) : base(statusCode)
        {
            Errors = new Dictionary<string, List<string>>();
        }

        public void Add(string key, IEnumerable<string> errors)
        {
            Errors.Add(key, errors.ToList());
        }
    }
}