using System;
namespace Homework5_1_PasswordCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "1q2w3e4r", passwordRequest;
            do
            {
                Console.WriteLine("Enter your password");
                passwordRequest = Console.ReadLine();
                if (password == passwordRequest)
                {
                    Console.WriteLine("Welcome back!");
                }
                else if (passwordRequest == "administrator")
                {
                    Console.WriteLine("Authorized as administrator.");
                    break;
                }
            }
            while (password != passwordRequest);
            Console.ReadKey();
        }
    }
}
