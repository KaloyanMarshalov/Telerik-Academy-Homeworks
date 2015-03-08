using System;
using System.Text.RegularExpressions;

//Write a program that parses an URL address given in the format: 
//[protocol]://[server]/[resource] and extracts from it the 
//[protocol], [server] and [resource] elements.

namespace _12.ParseURL
{
    class ParseURl
    {
        static void Main()
        {
            Console.Write("Insert URL: ");
            string url = Console.ReadLine();
            //string url = @"http://telerikacademy.com/Courses/Courses/Details/212";
            var fragments = Regex.Match(url, "(.*)://(.*?)(/.*)").Groups;

            Console.WriteLine("URL Address: {0}", url);
            Console.WriteLine("\n[protocol] = {0}", fragments[1]);
            Console.WriteLine("[server] = {0}", fragments[2]);
            Console.WriteLine("[resource] = {0}\n", fragments[3]);
        }
    }
}
