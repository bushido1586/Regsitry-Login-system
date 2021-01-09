using System;

namespace Register_LogIn_System
{
    class Program
    {
        static string userName;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
            
        }

        public static void Register()
        {
            Console.WriteLine("Please enter new username: ");
            userName = Console.ReadLine();
            Console.WriteLine("Please enter new password:" );
            password = Console.ReadLine();
            Console.WriteLine("Registration complete");
            Console.WriteLine("---------------------------");
        }
        public static void Login()
        {
            Console.WriteLine("Please enter username: ");
            if(userName == Console.ReadLine())
            {
                Console.WriteLine("Please enter your pasword:");
                    if(password == Console.ReadLine())
                {
                    Console.WriteLine("Login complete");
                }
                else
                {
                    Console.WriteLine("Login failed wrong password. Restart program");
                }
            }else
            {
                Console.WriteLine("Login fialed, Wrong username. Please restart");
            }
        }
    }
}
