using System;
using System.Text;

namespace ExtendString
{
    public static class StringExtensions
    {
        private static Random rnd;

        static StringExtensions()
        {
            rnd = new Random();
        }

        public static string ToRandomCase(this string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char c in s)
           {
               sb.Append(rnd.NextDouble() < 0.5 ? char.ToLower(c): char.ToUpper(c)); 
           }
           return sb.ToString();
        }
    }
}