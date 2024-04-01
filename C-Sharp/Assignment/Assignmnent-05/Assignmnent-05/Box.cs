
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05
{
    class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public Box Add(Box otherBox)
        {
            return new Box(Length + otherBox.Length, Breadth + otherBox.Breadth);
        }
    }

    class Tests
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the length of Box 1: ");
            double length1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Enter the breadth of Box 1: ");
            double breadth1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Enter the length of Box 2: ");
            double length2 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Enter the breadth of Box 2: ");
            double breadth2 = Convert.ToDouble(Console.ReadLine());



            Box box1 = new Box(length1, breadth1);
            Box box2 = new Box(length2, breadth2);


            Box resultBox = box1.Add(box2);

            Console.WriteLine($"Result Box : Length = {resultBox.Length} and Breadth = {resultBox.Breadth}");
            Console.Read();
        }
    }
}
