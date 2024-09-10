using System.Security.Cryptography;

namespace Reg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String email = "yousef@gmail.com";
            String password = "1234";

            String email2 = "";
            String password2 = "";

            Console.WriteLine("Welcome please login!!");
            Console.WriteLine("=========================");
            Console.WriteLine();

            Console.Write("Enter your email: ");
            email2 = Console.ReadLine();
            Console.WriteLine();
            
            emailError(email, email2);

            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("Welcome please login!");
            Console.WriteLine("=========================");
            Console.WriteLine();

            Console.Write("Enter your password: ");
            password2 = Console.ReadLine();
            Console.WriteLine();

            passError(password, password2);

            Thread.Sleep(1000);
            Console.Clear();

            Console.Write("Welcome ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Yousef ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("!");
            Console.WriteLine();

            Console.ReadKey();
        }

        static void emailError(String x, String y)
        {
            bool flag1 = false;
            bool flag2 = false;

            while (flag1 == false)
            {
                int c = 0;
                int c1 = 0;
                for (int i = 0; i < y.Length; i++)
                {
                    if (y[i] == '@')
                    {
                        ++c;
                    }
                    if (y[i] == '.')
                    {
                        ++c1;
                    }
                }

                if (c == 0 && c1 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Email should contain '@' and '.'!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.Write("Enter email again: ");
                    y = Console.ReadLine();
                    Console.WriteLine();
                }
                else if (c != 0 && c1 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Email should contain '.'!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.Write("Enter email again: ");
                    y = Console.ReadLine();
                    Console.WriteLine();
                }
                else if (c == 0 && c1 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Email should contain '@'!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.Write("Enter email again: ");
                    y = Console.ReadLine();
                    Console.WriteLine();
                }
                else
                {
                    flag1 = true;
                }
            }

            while (flag2 == false)
            {
                if (x != y)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Email does not match!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.Write("Enter email again: ");
                    y = Console.ReadLine();
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Email is correct!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    flag2 = true;
                }
            }
        }

        static void passError(String x, String y)
        {
            bool flag1 = false;
            while (flag1 == false)
            {
                if (x != y)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Password does not match!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.Write("Enter password again: ");
                    y = Console.ReadLine();
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Password is correct!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    flag1 = true;
                }
            }
        }
    }
}

