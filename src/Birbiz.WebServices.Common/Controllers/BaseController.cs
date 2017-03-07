using Birbiz.WebServices.Common.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Birbiz.WebServices.Common.Controllers
{
    public abstract class BaseController : Controller
    {
        [NonAction]
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!ModelState.IsValid)
            {
                context.Result = new JsonActionResult(new FormValidateResult(ModelState));
            }

            base.OnActionExecuting(context);
        }
    }
}