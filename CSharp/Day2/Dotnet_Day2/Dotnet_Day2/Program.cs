using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day2
{
    class ProgramConstructs
    {
        //if else
        public void CheckGrades()
        {
            char grade;
            int marks;
            Console.WriteLine("Enter your Grade O/A/B/C/D ");
            grade = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter your marks");
            marks = Convert.ToInt16(Console.ReadLine());
            if ((grade == 'O' || grade == 'o') && (marks > 90))
                Console.WriteLine("Outstanding");
            else if ((grade == 'A' || grade == 'a') && (marks > 85 || marks < 90))
                Console.WriteLine("Excellent");
            else if ((grade == 'B' || grade == 'b') && (marks > 80 || marks < 85))
                Console.WriteLine("Very Good");
            else if ((grade == 'C' || grade == 'c') && (marks > 70 || marks < 80))
                Console.WriteLine("Good");
            else if ((grade == 'D' || grade == 'd') && (marks > 35))
                Console.WriteLine("Can Improve");
            else
                Console.WriteLine("Invalid Grade");
        }
        static void Main()
        {
            ProgramConstructs pc = new ProgramConstructs();
            pc.CheckGrades();
            Console.Read();
        }
    }
}
