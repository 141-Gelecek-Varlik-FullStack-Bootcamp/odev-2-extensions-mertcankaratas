using Core.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.ActionFilters
{
    public class ValidationFilterAttribute : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //var param = context.ActionArguments.SingleOrDefault(p => p.Value is IEntity);
            //if (param.Value == null)
            //{
            //    context.Result = new BadRequestObjectResult("object is null");
            //    return;
            //}

            //context.Result = new OkObjectResult("teşekkürler");
            //return;

            //context.Result = new OkObjectResult("teşekkürler");
            UserType userType = UserType.Admin;
            if (userType!=UserType.Admin)
            {
                context.Result = new BadRequestObjectResult("object is null");
                return;
            }
        }
    }
}
