using System;
using System.Text.RegularExpressions;

namespace UC5
{
    internal class UR5
    {
        //writing the expression as we are needed
        public static string reg = "[A-Za-z1-9]{8}";

        public static bool Validate(String pass)//Check Validation Of password
        {
            return Regex.IsMatch(pass, reg);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Password");//Enter Teh Paasowd
            string password = Console.ReadLine();

            if (Validate(password))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }

        }
    }
}


