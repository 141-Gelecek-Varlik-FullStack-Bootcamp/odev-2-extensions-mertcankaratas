using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Core.Attributes
{
    public class LogAttribute:Attribute,IActionFilter
    {

       
         public LogAttribute()
        {
            var time = DateTime.Now;
            var message = "Logged in:" + time;
            Console.WriteLine(message);

        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Console.WriteLine("Method sonu loglandı");              
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Console.WriteLine("Method bası loglandı");
        }
    }
}
