﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Resources;
using System.Drawing;
using ProjectWatcher.Resources;

namespace ProjectWatcher.Helpers
{
    public static class ResourcesHelper
    {
        private static Dictionary<String, ResourceManager> localizedResourses;
        

        private static ResourceManager commonResourses;

        public static bool LoadResourses()
        {   
            try
            {
                commonResourses = Common.ResourceManager;
                localizedResourses = new Dictionary<String, ResourceManager>();
                localizedResourses["ru-RU"] = RussianText.ResourceManager;
                localizedResourses["en-US"] = EnglishText.ResourceManager;
            }
            catch {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Returns message in specified language
        /// </summary>
        /// <param name="name">name of message in resource file</param>
        /// <param name="language">Language in "en-US" format</param>
        public static string GetText(string name, string language)
        {
            ResourceManager specifiedLanguage = GetLocalizedResourses(language);
            try
            {
                return specifiedLanguage.GetString(name);
            }
            catch(Exception)
            {
                return "Message" + name + "was not declared in resourses"; 
            }
        }

        public static Image GetImage(string name)
        {
            
            return (Image)commonResourses.GetObject(name);
        }

        private static ResourceManager GetLocalizedResourses(String culture)
        {
            if(localizedResourses.ContainsKey(culture))
            {
                return localizedResourses[culture];
            }
            else
            {
                return localizedResourses["en-US"];
            }
        }



    }
}