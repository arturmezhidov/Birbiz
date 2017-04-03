using Microsoft.AspNetCore.Mvc;

namespace Birbiz.WebServices.Common.Results
{
    public class EmptyResultValue : IResultValue
    {
        public object Execute(ActionContext context)
        {
            return new object();
        }
    }
}