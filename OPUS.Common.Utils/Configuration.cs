using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Common.Utils
{
    public static class Configuration
    {
        private const string _DATE_TIME_FORMAT = "DATE_TIME_FORMAT";
        public static string DATE_TIME_FORMAT
        {
            get
            {
                return ConfigurationManager.AppSettings.Get(_DATE_TIME_FORMAT);
            }
        }
    }
}
