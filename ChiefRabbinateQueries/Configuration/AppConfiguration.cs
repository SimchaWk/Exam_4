using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiefRabbinateQueries.Configuration
{
    internal static class AppConfiguration
    {
        public static string filePath = Path.Combine(
            Directory.GetCurrentDirectory(),
            "ChiefRabbinateQueries.xml"
            );
    }
}
