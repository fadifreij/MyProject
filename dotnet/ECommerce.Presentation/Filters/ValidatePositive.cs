using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Presentation.Filters
{
    public class ValidatePositiveIntAttribute :  ActionFilterAttribute
    {
        private readonly string[] parameterNames;

        public ValidatePositiveIntAttribute(params string[] parameterName)
        {
            this.parameterNames = parameterNames ?? [];
        }


        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            foreach (var paramName in parameterNames)
            {
                if (context.ActionArguments.TryGetValue(paramName, out var value) && value is int intValue && intValue <= 0)
                {
                    if (intValue <= 0)
                    {
                        context.Result = new BadRequestObjectResult($"{paramName} must be a positive integer.");
                        return Task.CompletedTask;
                    }
                }
            }


            return base.OnActionExecutionAsync(context, next);
        }
    }
}
