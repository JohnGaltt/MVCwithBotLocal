using System.Web;
using System.Web.Mvc;

namespace IdeatonEntityFram07._10._2017
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
