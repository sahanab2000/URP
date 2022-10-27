using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;


namespace UR3
{
    internal class UR3
    {
        //writing the expression as we are needed
        public static string reg = "^[a-z]{3}[1-9]{2}[.][a-z]{3}[1-9]{2}@[a-z]{2}[.][a-z]{2}[.][a-z]{2}";

        public static bool Validate(string emailid)
        {
            return Regex.IsMatch(emailid, reg);//Check Validate Of Emial Address
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Email Address");//Accept Mail Id From User
            string email = Console.ReadLine();

            if (Validate(email))
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
