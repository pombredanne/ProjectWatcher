﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace ProjectWatcher.Helpers
{
    public class HttpContextHelper
    {
        protected HttpContextBase context;

        protected static String cultureTemplate = @"\w{2}-\w{2}";

        public HttpContextHelper(HttpContextBase context)
        {
            this.context = context; 
        }

        /// <summary>
        /// Gets culture from cookies, sets default culture if it wasn't in cookies
        /// </summary>
        /// <returns>Culture in "en-US" format</returns>
        public String GetCulture()
        {
            HttpCookie cookieCulture = context.Request.Cookies["culture"];
            String culture;           
            if (cookieCulture == null || !Regex.IsMatch(cookieCulture.ToString(), cultureTemplate))
            {
                culture = SettingsHelper.Instance.DefaultCulture;
                context.Response.Cookies.Add(new HttpCookie("culture", culture));                                   
            }
            else
            {
                culture = cookieCulture.ToString();
            }
            return culture;
        }
    }
}