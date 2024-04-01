
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your First Name: ");
            string fname = Console.ReadLine();
            Console.Write("Write your Last Name: ");
            string lname = Console.ReadLine();
            display(fname, lname);
            Console.ReadKey();
        }
        static void display(string fname, string lname)
        {
            fname = fname.ToUpper();
            lname = lname.ToUpper();
            Console.WriteLine($"First Name: {fname}");
            Console.WriteLine($"Last Name: {lname}");
            Console.Read();
        }

    }
}
