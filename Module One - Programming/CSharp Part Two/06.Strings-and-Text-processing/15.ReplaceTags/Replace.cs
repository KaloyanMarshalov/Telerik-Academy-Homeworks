﻿using System;
using System.Text.RegularExpressions;

//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

namespace _15.ReplaceTags
{
    class Replace
    {
        static void Main()
        {
            Console.Write("Insert html: ");
            string html = Console.ReadLine();
            //string html = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
            Console.WriteLine(Regex.Replace(html, @"<a href=""(.*?)"">(.*?)</a>", @"[URL=$1]$2[/URL]"));
        }
    }
}
