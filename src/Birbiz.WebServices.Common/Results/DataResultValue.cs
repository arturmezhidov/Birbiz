using Microsoft.AspNetCore.Mvc;

namespace Birbiz.WebServices.Common.Results
{
    public class DataResultValue : IResultValue
    {
        private readonly object data;

        public DataResultValue(object data)
        {
            this.data = data;
        }

        public object Execute(ActionContext context)
        {
            return data ?? new object();
        }
    }
}