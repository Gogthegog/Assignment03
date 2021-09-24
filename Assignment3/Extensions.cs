using System;

namespace BDSA2021.Assignment03
{
    public static class Extensions
    {

        public static bool IsSecure(this Uri Uri) 
        {
            return (Uri.ToString().StartsWith("https")) ? true : false;
        }

        public static int WordCount(this string str) 
        {
            return str.Split(
                new char[] {' ', '.', '?'}, StringSplitOptions.RemoveEmptyEntries).Length;            
        }
    }
}
