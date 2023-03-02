using System.Web;
using System.Web.Mvc;

namespace Chieut6_Tuan4_2080600088
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
