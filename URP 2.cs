using System;
using System.Text.RegularExpressions;

namespace UR2
{
    internal class UR2
    {
        public static string reg = "^[A-Z][a-za-z]{2,}";
        public static bool Validate(string words)
        {
            return Regex.IsMatch(words, reg);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Last Name");
            string lname = Console.ReadLine();

            if (Validate(lname))
            {
                Console.WriteLine("Valid Data");
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }
        }
    }
}
