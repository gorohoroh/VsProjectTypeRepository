﻿using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Web_Application_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
