using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    class Program
    {
        static string firstName, lastName;
        static void Display(string firstName, string lastName)
        {
            Console.WriteLine($"First Name:" + firstName);
            Console.WriteLine($"Last Name:" + lastName);


            Console.WriteLine("After converting into uppercase");
            string upperFirstName = firstName.ToUpper();
            string upperLastName = lastName.ToUpper();
            Console.WriteLine($"First Name in Uppercase:" + upperFirstName);
            Console.WriteLine($"Last Name in Uppercase:" + upperLastName);


        }
        static void Main(string[] args)
        {
            Program s = new Program();
            Console.WriteLine("enter the your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("enter the your last name:");
            string lastName = Console.ReadLine();
            Display(firstName, lastName);

            Console.Read();


        }
    }
}