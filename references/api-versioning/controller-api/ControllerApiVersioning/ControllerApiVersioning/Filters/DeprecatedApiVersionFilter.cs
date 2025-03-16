using Microsoft.AspNetCore.Mvc.Filters;

namespace ControllerApiVersioning.Filters
{
    public class DeprecatedApiVersionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var apiVersion = context.HttpContext.GetRequestedApiVersion();
            if (apiVersion?.MajorVersion == 1 && apiVersion?.MinorVersion == 0) // Check for version 1
            {
                context.HttpContext.Response.Headers["Deprecation"] = "true";
                context.HttpContext.Response.Headers["Warning"] = "1 This API version is deprecated and will be removed in the future.";
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            // No action needed after the action executes.
        }
    }
}
