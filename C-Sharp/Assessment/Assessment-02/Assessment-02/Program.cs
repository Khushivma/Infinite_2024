
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_02
{
    class Program
    {
        static void Main(string[] args)
        {
            forUnderGraduate();
            forGraduate();

            Console.ReadKey();

        }
        static void forUnderGraduate()
        {
            Console.WriteLine("For Undergraduate\n");
            UnderGraduate ugd = new UnderGraduate();
            Console.Write("Write Student ID: ");
            ugd.StudentID = int.Parse(Console.ReadLine());
            Console.Write("Write Student Name: ");
            ugd.Name = Console.ReadLine();
            Console.Write("Write Student Grade: ");
            ugd.Grade = Convert.ToSingle(Console.ReadLine());

            bool temp = ugd.isPassed(ugd.Grade);
            if (temp == true)
            {
                Console.WriteLine("Result: Passed");

            }
            else
            {
                Console.WriteLine("Result: Failed");

            }
        }
        static void forGraduate()
        {
            Console.WriteLine("For Graduate\n");
            Graduate ugd = new Graduate();
            Console.Write("Write Student ID: ");
            ugd.StudentID = int.Parse(Console.ReadLine());
            Console.Write("Write Student Name: ");
            ugd.Name = Console.ReadLine();
            Console.Write("Write Student Grade: ");
            ugd.Grade = Convert.ToSingle(Console.ReadLine());

            bool temp = ugd.isPassed(ugd.Grade);
            if (temp == true)
            {
                Console.WriteLine("Result: Passed");

            }
            else
            {
                Console.WriteLine("Result: Failed");

            }
        }
    }
}
