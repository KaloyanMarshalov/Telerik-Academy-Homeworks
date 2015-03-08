using System;
using System.Net;
using System.IO;

namespace _04.DownloadFile
{
    class DownloadFile
    {
        static void Main(string[] args)
        {
            using (WebClient downloadClient = new WebClient())
            {
                try
                {
                    Console.WriteLine("Downloading..");
                    downloadClient.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "news-img01.png");
                    Console.WriteLine("Image was downloaded successfully in 'bin' directory of the project: {0}",  Directory.GetCurrentDirectory());
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (WebException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (NotSupportedException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Goodbye!");
                }
            }

        }
    }
}
