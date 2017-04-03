using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Birbiz.WebServices.Common.Results;

namespace Birbiz.WebServices.Common.Controllers
{
    public abstract class BaseController : Controller
    {
        [NonAction]
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!ModelState.IsValid)
            {
                context.Result = new JsonBadRequestResult(new ModelValidateErrorResultValue());
            }

            base.OnActionExecuting(context);
        }

        [NonAction]
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (!ModelState.IsValid)
            {
                context.Result = new JsonBadRequestResult(new ModelValidateErrorResultValue());
            }

            base.OnActionExecuted(context);
        }

        [NonAction]
        public override JsonResult Json(object value)
        {
            return base.Json(value, new LowerCaseJsonSerializerSettings());
        }

        [NonAction]
        public virtual JsonOkResult JsonOk()
        {
            return new JsonOkResult(new EmptyResultValue());
        }

        [NonAction]
        public virtual JsonOkResult JsonOk(object value)
        {
            return new JsonOkResult(new DataResultValue(value));
        }

        [NonAction]
        public virtual JsonOkResult JsonOk(IResultValue value)
        {
            return new JsonOkResult(value);
        }

        [NonAction]
        public virtual JsonBadRequestResult JsonBadRequest()
        {
            return new JsonBadRequestResult(new EmptyResultValue());
        }

        [NonAction]
        public virtual JsonBadRequestResult JsonBadRequest(ErrorResultValue value)
        {
            return new JsonBadRequestResult(value);
        }
    }
}