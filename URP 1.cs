using System;
using System.Text.RegularExpressions;

namespace UR1
{
    internal class UR1
    {
        // the expression as we are needed
        public static string reg = "^[A-Z][A-za-z]{2,}";
        public static bool validate(string word)
        {
            //Return True,if match
            return Regex.IsMatch(word, reg);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter The First Name:");//Accept Name
            String fname = Console.ReadLine();

            if (validate(fname))//Check Valid OR Not
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
