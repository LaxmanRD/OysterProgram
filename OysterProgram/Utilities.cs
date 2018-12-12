using System;
using System.Linq;
using System.Text;

namespace OysterProgram
{
    public enum TransportOptions { Bus, Tube };

    public static class Common
    {
        public static string RemoveSpecialCharacters(this string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_' || c == ' ')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString().ToLower();
        }

        public static string IntersecZones(string x1, string x2)
        {
            string[] string1 = x1.Split(',');
            string[] string2 = x2.Split(',');
            var m = string1.Distinct();
            var n = string2.Distinct();
            var commonString = " ";

            var results = m.Intersect(n, StringComparer.OrdinalIgnoreCase);
            foreach (var k in results) commonString += k + " ";
            return commonString;
        }
    }
}