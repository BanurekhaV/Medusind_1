using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;


namespace FilterExceptionPrj.Models
{
    public class CustomLogsFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if(!filterContext.ExceptionHandled)
            {
                var ExMessage = filterContext.Exception.Message;
                var stackTrace = filterContext.Exception.StackTrace;
                var controllerName = filterContext.RouteData.Values["controller"].ToString();
                var actionName = filterContext.RouteData.Values["action"].ToString();

                string details = "Date :" + DateTime.Now.ToString() + "Controller  :" + controllerName +
                    "Action Method : " + actionName + "Error Details :" + ExMessage + "\n" + "Trace :" +
                    stackTrace;

                //the above collected data is to be appended to a physical file
                File.AppendAllText(HttpContext.Current.Server.MapPath("~/ErrorLog/Log.txt"), details);
                filterContext.ExceptionHandled = true;
                filterContext.Result = new ViewResult()
                { ViewName = "Error" }; //redirect to an view
            }
        }
    }
}