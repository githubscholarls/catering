using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catering.Infrastructure
{
    public static class HelperMethodExtension
    {
        public static void ConvertURL(this string url)
        {
            if (url == null)
                return;
            url.Replace("%2F", "/");
        }
    }
}
