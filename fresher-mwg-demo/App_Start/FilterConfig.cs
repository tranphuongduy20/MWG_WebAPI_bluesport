﻿using System.Web;
using System.Web.Mvc;

namespace fresher_mwg_demo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}