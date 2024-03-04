using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qno_01
{
    class Qno_02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Read();
            if (n > 0)
            {
                Console.WriteLine($"{n} is positive number");
            }
            else if (n < 0)
            {
                Console.WriteLine($"{n} is negative number");
            }
            else
            {
                Console.WriteLine($"{n} is zero");
            }
        }
    }
}
