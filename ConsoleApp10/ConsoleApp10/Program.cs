using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string first, last;
            Console.WriteLine("Enter your name:");
            first= Console.ReadLine();
            Console.WriteLine("Enter your name:");
            last = Console.ReadLine();
            Console.WriteLine("Hello, {0} {1}" , first, last);
            Console.ReadLine(); 
        }
    }
}
