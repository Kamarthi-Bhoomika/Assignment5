using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <3; i++)
            {
                Console.WriteLine("Enter User Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Password: ");
                string pwd = Console.ReadLine();

                if (name == "Bhoomika" && pwd == "Bhoomika123")
                {
                    Console.WriteLine("Login Successfull!!");
                }
                else if (name != "Bhoomika")
                {
                    Console.WriteLine("Invalid UserName");
                }
                else if (name == "Bhoomika" && pwd != "Bhoomika123")
                {
                    Console.WriteLine("Invalid Password");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Login Failed");
            Console.ReadKey();
        }
    }
}
