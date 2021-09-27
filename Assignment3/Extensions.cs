using System;
using System.Collections.Generic;

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

        public static void Print<T>(this IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintSingle<T>(this T item) => Console.WriteLine(item);
        
    }
}
