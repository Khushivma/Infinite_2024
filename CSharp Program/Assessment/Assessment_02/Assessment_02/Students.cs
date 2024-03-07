using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_02
{
    abstract class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }

        public abstract bool IsPassed(double grade);
    }

    class Undergraduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }

    class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }

    class Students
    {
        static void Main(string[] args)
        {

            Console.Write("Enter student name is: ");
            string name = Console.ReadLine();

            Console.Write("Enter student ID: ");
            int studentId = int.Parse(Console.ReadLine());

            Console.Write("Enter student grade: ");
            double grade = double.Parse(Console.ReadLine());


            Undergraduate undergrad = new Undergraduate();
            undergrad.Name = name;
            undergrad.StudentId = studentId;
            undergrad.Grade = grade;


            Graduate grad = new Graduate();
            grad.Name = name;
            grad.StudentId = studentId;
            grad.Grade = grade;


            Console.WriteLine("Undergraduate student passed: " + undergrad.IsPassed(grade));
            Console.WriteLine("Graduate student passed: " + grad.IsPassed(grade));
            Console.Read();
        }
    }
}
