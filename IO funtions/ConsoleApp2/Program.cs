using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello, enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your experience");
            int exp = int.Parse(Console.ReadLine());
            if (exp > 2)
            {
                Console.WriteLine("You are Experienced");
            }
            else
            {
                Console.WriteLine("You are a Fresher");
            }
        }
    }
}
