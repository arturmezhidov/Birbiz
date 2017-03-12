using Birbiz.WebServices.Common.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Birbiz.WebServices.Common.Controllers
{
    public abstract class BaseController : Controller
    {
        [NonAction]
        public override JsonResult Json(object data)
        {
            return base.Json(data, new LowerCaseJsonSerializerSettings());
        }

        [NonAction]
        public virtual JsonResult Json(BaseResult result)
        {
            return new JsonActionResult(result);
        }

        [NonAction]
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!ModelState.IsValid)
            {
                context.Result = new JsonActionResult(new ModelValidateResult(ModelState));
            }

            base.OnActionExecuting(context);
        }

        [NonAction]
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (!ModelState.IsValid)
            {
                context.Result = new JsonActionResult(new ModelValidateResult(ModelState));
            }

            base.OnActionExecuted(context);
        }
    }
}