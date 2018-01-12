using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace MVC.Controllers
{
    public class FilterController : Controller
    {
        // GET: Filter
        [AuthenticationFilter]
        [AuthorizationFilter]
        [ActionFilter]
        [ResultFilter]
        [ExceptionFilter]
        [HandleError]
        public ActionResult FilterTest()
        {
            int i = 0;
            int k = 2 / i;
            return View();
        }       
    }

    public class AuthenticationFilter : FilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            Console.WriteLine("OnAuthentication");
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            Console.WriteLine("OnAuthenticationChallenge");
        }
    }

    public class AuthorizationFilter : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            Console.WriteLine("OnAuthorization");
        }
    }
    public class ActionFilter : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Console.WriteLine("OnActionExecuted");
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Console.WriteLine("OnActionExecuting");
        }
    }

    public class ResultFilter : FilterAttribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Console.WriteLine("OnResultExecuted");
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Console.WriteLine("OnResultExecuting");
        }
    }

    public class ExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            try
            {
                filterContext.ExceptionHandled = true;
                Console.WriteLine("OnException");
            }
            catch (Exception)
            {

            }
            
        }
    }
}
