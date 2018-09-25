using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountLibrary
{
    class Helper
    {
        public static string ConnectionString1
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings["AccountDBConnectionString1"].ConnectionString;
            }
        }
        public static string ConnectionString2
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings["AccountDBConnectionString2"].ConnectionString;
            }
        }

    }
}
