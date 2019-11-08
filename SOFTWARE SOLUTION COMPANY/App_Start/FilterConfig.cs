using System.Web;
using System.Web.Mvc;

namespace SOFTWARE_SOLUTION_COMPANY
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
