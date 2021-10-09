using System;
using System.Collections.Generic;

namespace Laboration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your datastring: ");
            
            string stringInput = Console.ReadLine();
            Console.Write("\n");

            List<string> substringList = new List<string>();


            for (int i = 0; i < stringInput.Length - 1; i++)
            {
                if (Char.IsDigit(stringInput[i]))
                {
                    for (int j = i + 1; j < stringInput.Length; j++)
                    {
                        if (Char.IsDigit(stringInput[j]))
                        {
                            if (stringInput[i] == stringInput[j])
                            {
                                string substring = stringInput.Substring(i, j - i + 1);
                                substringList.Add(substring);
                                PrintSubstring(stringInput, i, j);
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("\nThe sum is: " + ResultOfList(substringList));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
        static void PrintSubstring(string stringInput, int startValue, int end)
        {
            string firstString = stringInput.Substring(0, startValue);
            string secondString = stringInput.Substring(startValue, end - startValue + 1);
            string thirdString = stringInput.Substring(end + 1);

            Console.Write(firstString);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(secondString);

            Console.ResetColor();
            Console.WriteLine(thirdString);
        }
        static ulong ResultOfList (List<string> list)
        {
            ulong sumOfList = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sumOfList += Convert.ToUInt64(list[1]);
            }
            return sumOfList;
        }
    }
}
