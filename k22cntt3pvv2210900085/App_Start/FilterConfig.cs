using System.Web;
using System.Web.Mvc;

namespace k22cntt3pvv2210900085
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
