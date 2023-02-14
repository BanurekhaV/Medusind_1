using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterExceptionPrj.Models
{
    public class LogicFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.ActionMessage1 = "Custom Action Filter .. On ActionExecuting";
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.ResultMessage1 = "Custom Result Filter .. On ResultExecuting";
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.Controller.ViewBag.ActionMessage2 = "Custom Action Filter .. On ActionExecuted";
        }
            
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.Controller.ViewBag.ResultMessage2 = "Custom Result Filter .. On ResultExecuting";
        }
    }
}