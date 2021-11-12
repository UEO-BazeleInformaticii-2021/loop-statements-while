using System;

namespace LoopStatementsWhile
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ImplementationWithDoWhile();
        }

        /// <summary>
        /// Implements the autentication with a while loop.
        /// </summary>
        static void ImplementationWihWhile()
        {
            string secretUser = "admin";
            string secretPassword = "12345";

            Console.WriteLine("Hello, please authenticate first!");
            while (true)
            {
                Console.Write("User=");
                string user = Console.ReadLine();

                Console.Write("Password=");
                string password = Console.ReadLine();

                if (string.Equals(user, secretUser, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(password, secretPassword, StringComparison.Ordinal))
                {
                    Console.WriteLine($"Wellcome {user}!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Username or password mismatched, please try again");
                }
            }
        }

        static void ImplementationWithDoWhile()
        {
            string secretUser = "admin";
            string secretPassword = "12345";

            Console.WriteLine("Hello, please authenticate first!");
            bool isAuthenticated = false;
            do
            {
                Console.Write("User=");
                string user = Console.ReadLine();

                Console.Write("Password=");
                string password = Console.ReadLine();

                if (string.Equals(user, secretUser, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(password, secretPassword, StringComparison.Ordinal))
                {
                    Console.WriteLine($"Wellcome {user}!");
                    isAuthenticated = true;
                }
                else
                {
                    Console.WriteLine($"Username or password mismatched, please try again");
                }
            }
            while (!isAuthenticated);
        }
    }
}
