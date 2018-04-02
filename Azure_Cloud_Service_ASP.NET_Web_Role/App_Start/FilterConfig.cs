using System.Web;
using System.Web.Mvc;

namespace Azure_Cloud_Service_ASP.NET_Web_Role
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
