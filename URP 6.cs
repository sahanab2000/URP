using System;
using System.Text.RegularExpressions;

namespace UR6
{
    internal class UR6
    {
        //writing the expression as we are needed
        public static string reg = "(?=.*[A-Z]).{8}";
        public static bool validate(string word)
        {
            //return true if the word matches the regex
            return Regex.IsMatch(word, reg);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter The Password:");
            String pass = Console.ReadLine();

            if (validate(pass))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}


