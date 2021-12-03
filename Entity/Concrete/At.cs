using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Entity.Concrete
{ //IActionFilter
    [System.AttributeUsage(AttributeTargets.Method)]
    public class At : Attribute
    {
      private readonly string _test;
        public At(string test)
        {
        
           this._test = test;
            Console.WriteLine("Attribute tetiklendi");
        }
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {

            //var type = typeof(At);
            //At at = (At)Activator.CreateInstance(type);
            //at.GetCustomAttribute(filterContext);



        }


        public void OnActionExecuting(ActionExecutingContext filterContext)
        {

        
        }
    }
}
