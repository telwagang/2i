using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace _2i.Helpers
{
    public static class _2iHelper
    {
        public static string GetAppSettingString(string key)
        {
            var ret = string.Empty;

            var k = ConfigurationManager.AppSettings[key];

            if (k == null)
            {
                //InfLogger.Error($"App setting with key {key} not found.");
                return ret;
            }

            if (string.IsNullOrWhiteSpace(k))
            {
                //InfLogger.Error($"App setting with key {key} is empty.");
                return ret;
            }

            return k;
        }
    }
}