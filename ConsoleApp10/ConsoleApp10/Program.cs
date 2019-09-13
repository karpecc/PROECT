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
            string name;
            Console.WriteLine("Enter yor name:");
            name= Console.ReadLine();
            Console.WriteLine("Hello {0}" , name);
            Console.ReadLine(); 
        }
    }
}
