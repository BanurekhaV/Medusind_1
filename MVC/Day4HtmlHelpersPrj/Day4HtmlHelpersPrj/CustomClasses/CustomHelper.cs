using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day4HtmlHelpersPrj.CustomClasses
{
    public class CustomHelper
    {
        public static IHtmlString LabelWithMark(string content)
        {
            string htmlstr = String.Format("<Label><b><i><mark>{0}</mark></i></b></Label>", content);
            return new HtmlString(htmlstr);
        }
    }
}