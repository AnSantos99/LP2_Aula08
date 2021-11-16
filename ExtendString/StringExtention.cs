using System;
using System.IO;
using System.Text;

namespace ExtendString
{
    public static class StringExtention
    {
        private static Random rnd;

        static StringExtention()
        {
            rnd = new Random();
        }

        public static string ToRandomCase(this string s)
        {
            StringBuilder sb = new StringBuilder();

            foreach(Char c in s)
            {
                sb.Append(rnd.NextDouble() < 0.5 ? 
                    char.ToLower(c) : char.ToUpper(c));
            }
            return sb.ToString();
        }
    }
}