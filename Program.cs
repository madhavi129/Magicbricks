using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MClib;

namespace Magicbricks
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation op = new Operation();
            Valid val = new Valid();
            Console.WriteLine("--Register--");
            Console.Write("Enter username :");
            string UserName = Console.ReadLine();
            bool validPassword;
            string password;
            Console.Write("Please Enter password :");
            password = Console.ReadLine();
            validPassword = val.IsValidPassword(password);
            while (!validPassword)
            {
                Console.Write("Please Enter proper password :");
                password = Console.ReadLine();
                validPassword = val.IsValidPassword(password);
            }
            Console.Write("Enter Phone :");
            long phone = Convert.ToInt64(Console.ReadLine());

            bool signin = val.Signin(UserName, password, phone);
            Console.WriteLine("Register: {0}", signin);

            Console.WriteLine("--Login--");
            Console.Write("Enter username :");
            string luserName = Console.ReadLine();
            Console.Write("Enter password :");
            string lpassword = Console.ReadLine();

            for (int i = 1; i <= 5; i++)
            {
                if (password == lpassword && luserName == UserName)
                {
                    Console.WriteLine("Login: " + signin);
                    op.Op();
                }
                else
                {
                    Console.WriteLine("Invalid Credentials");

                    Console.WriteLine("Enter username :");
                    luserName = Console.ReadLine();
                    Console.Write("Enter password :");
                    lpassword = Console.ReadLine();

                }
            }
            Console.Read();
        }
    }
}


