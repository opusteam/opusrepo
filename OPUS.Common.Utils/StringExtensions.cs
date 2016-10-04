using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPUS.Common.Utils
{
    public static class StringExtensions
    {
        public static T? ToEnumSafe<T>(this string s) where T : struct
        {
            if (string.IsNullOrEmpty(s)) return null;

            Type enumType = typeof(T);
            return (enumType.IsEnum ? (T?)Enum.Parse(typeof(T), s) : null);
        }
    }
}
