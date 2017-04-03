using Microsoft.AspNetCore.Mvc;

namespace Birbiz.WebServices.Common.Results
{
    public interface IResultValue
    {
        object Execute(ActionContext context);
    }
}