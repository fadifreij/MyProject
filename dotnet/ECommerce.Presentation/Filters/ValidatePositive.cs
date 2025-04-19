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
        private readonly string parameterName;

        public ValidatePositiveIntAttribute(string parameterName)
        {
            this.parameterName = parameterName;
        }


        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
           if (context.ActionArguments.TryGetValue(parameterName, out var value) && value is int intValue && intValue <=0)
            {
                if (intValue <= 0)
                {
                    context.Result = new BadRequestObjectResult($"{parameterName} must be a positive integer.");
                    return Task.CompletedTask;
                }
            }


            return base.OnActionExecutionAsync(context, next);
        }
    }
}
