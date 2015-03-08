using System;
using System.IO;

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

namespace _03.ReadFileContents
{
    class FileContents
    {
        static void ReadFile(string path)
        {
            string fileContents = File.ReadAllText(path);
            Console.WriteLine(fileContents);
        }
        static void Main()
        {
            try
            {
                Console.Write("Insert path: ");
                string path = Console.ReadLine();

                ReadFile(path);
            }
            catch (ArgumentException ar)
            {
                Console.WriteLine(ar.Message);
            }
            catch (PathTooLongException ptl)
            {
                Console.WriteLine("The path is too long!");
            }
            catch (DirectoryNotFoundException dnf)
            {
                Console.WriteLine("Not found!");
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }
            catch (UnauthorizedAccessException acc)
            {
                Console.WriteLine("Unathorized Access!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
