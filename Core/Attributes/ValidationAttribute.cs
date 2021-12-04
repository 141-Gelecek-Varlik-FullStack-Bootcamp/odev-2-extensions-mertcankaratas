using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Core.Attributes
{
    public class ValidationAttribute : Attribute, IActionFilter
    {
        string _userType;

        public ValidationAttribute(string userType)
        {
            _userType = userType;
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (_userType != "Admin")
            {
                throw new Exception("Bu kullancının yetkisi yoktur");
            }
        }
    }
}
