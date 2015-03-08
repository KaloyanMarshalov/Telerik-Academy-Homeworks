using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Konspiration
{
    class Konspiration
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var methods = new Dictionary<string, int>();
            string currentKey = string.Empty;
            List<string> MethodCalls = new List<string>();
            bool firstTimeDot = false;
            int dotIndex = 0;
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                int bracketIndex = line.IndexOf('(');
                if (bracketIndex >= 0)
                {
                    int staticIndex = line.IndexOf("static");
                    if (staticIndex >= 0)
                    {
                        string[] elemets = line.Split(new string[] { " ", ".", "(" }, StringSplitOptions.RemoveEmptyEntries);
                        methods.Add(elemets[2], 0);
                        currentKey = elemets[2];
                    }
                    else
                    {
                        while (bracketIndex > -1)
                        {
                            
                            if (!firstTimeDot)
                            {
                                 dotIndex = line.IndexOf(".");
                                 firstTimeDot = true;
                            }
                            if (dotIndex >= 0)
                            {
                                if (bracketIndex > dotIndex)
                                {
                                    string methodCall = line.Substring(dotIndex + 1, bracketIndex - dotIndex - 1);
                                    methods[currentKey] = methods[currentKey] + 1;
                                    MethodCalls.Add(methodCall);
                                }
                                else
                                {
                                    bracketIndex = line.IndexOf("(", dotIndex);
                                    if (bracketIndex > -1)
                                    {
                                        string methodCall = line.Substring(dotIndex + 1, bracketIndex - dotIndex - 1);
                                        methods[currentKey] = methods[currentKey] + 1;
                                        MethodCalls.Add(methodCall);
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                dotIndex = line.IndexOf('.', dotIndex + 1);
                                bracketIndex = line.IndexOf('(', bracketIndex + 1);
                            }
                            else
                            {
                                string[] elements = line.Split(new string[] { " ", "(" }, StringSplitOptions.RemoveEmptyEntries);
                                string methodCall = elements[0];
                                if (methodCall[0] >= 'A' && methodCall[0] <= 'Z' && methodCall.IndexOf("<") == -1)
                                {
                                    methods[currentKey] = methods[currentKey] + 1;
                                    MethodCalls.Add(methodCall);
                                }

                                int newBracketIndex = line.IndexOf('(', bracketIndex + 1);
                                if (newBracketIndex > -1)
                                {
                                    int length = newBracketIndex - bracketIndex - 1;
                                    if (length > 0)
                                    {
                                        methodCall = line.Substring(bracketIndex + 1, newBracketIndex - bracketIndex - 1);
                                    methods[currentKey] = methods[currentKey] + 1;
                                    MethodCalls.Add(methodCall);
                                    }
                                    
                                }
                                break;
                            }    
                        }
                        firstTimeDot = false;
                    }
                }
            }
            int j = 0;
            foreach (var method in methods)
            {
                Console.Write("{0} -> {1} -> ", method.Key, method.Value);
                if (method.Value == 0)
                {
                    Console.Write("None");
                }
                for (int i = 0; i < method.Value; i++)
                {
                    if (i + 1 != method.Value)
                    {
                        Console.Write("{0}, ", MethodCalls[j]);
                    }
                    else
                    {
                        Console.Write("{0}", MethodCalls[j]);
                    }
                    j++;
                }
                Console.WriteLine();
            }
        }
    }
}

