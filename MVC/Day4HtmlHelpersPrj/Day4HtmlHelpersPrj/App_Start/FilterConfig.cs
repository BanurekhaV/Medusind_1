using System.Web;
using System.Web.Mvc;

namespace Day4HtmlHelpersPrj
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
