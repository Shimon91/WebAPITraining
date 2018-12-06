using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPITraining.Utils
{
    public static class Configurationutils
    {
        public static string GetConfigValue(string key, string defaultValue = "")
        {
            var finalValue = ConfigurationManager.AppSettings[key];
            if (string.IsNullOrEmpty(finalValue))
            {
                finalValue = defaultValue;
            }
            return finalValue;
        }

        public static T GetConfigValue<T>(string key, T defaultValue = default(T)) where T : IConvertible
        {
            T finalValue = defaultValue;
            try
            {
                var finalValueStr = GetConfigValue(key);
                if (!string.IsNullOrEmpty(finalValueStr))
                {
                    finalValue = (T)Convert.ChangeType(finalValueStr, typeof(T));
                }
            }
            catch (Exception)
            {
                finalValue = defaultValue;
            }
            return finalValue;
        }
    }
}
