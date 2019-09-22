using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Pakohuone.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminControllerBase : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ActionDescriptor is ControllerActionDescriptor controllerActionDescriptor)
                ViewData["ExecutedController"] = controllerActionDescriptor.ControllerTypeInfo;
        }
    }
}
