using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endpoints
{
    public class SecurityCodes
    {
        public static List<string> codes = new List<string>();

        public static string generateNewCode()
        {
            Random rnd = new Random();
            string num = rnd.Next(99999, 1000000).ToString();
            codes.Add(num);
            return num;
        }
    }
}
