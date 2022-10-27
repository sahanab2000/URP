using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace UR4
{
    internal class UR4
    {
        //writing the expression as we are needed
        public static string reg = "^[91]{2,2}[\\s][1-9]{10,10}";

        public static bool Validate(String Number)
        {
            return Regex.IsMatch(Number, reg);//Check Validate Mobile Number
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Mobile Number");//Accept Mobile Number From The User
            string Mob = Console.ReadLine();
            if (Validate(Mob))
            {
                Console.WriteLine("Valid Number");

            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
        }
    }
}

