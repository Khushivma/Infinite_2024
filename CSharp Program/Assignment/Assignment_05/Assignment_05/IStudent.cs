using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05
{
public interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }

        void ShowDetails();
    }

    
    public class Dayscholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Dayscholar Details: StudentId = {StudentId}, Name = {Name}");
        }
    }

    
    public class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Resident Details: StudentId = {StudentId}, Name = {Name}");
        }
    }

    class School
    {
        static void Main(string[] args)
        {
            Dayscholar dayscholar = new Dayscholar();
            Console.Write("Dayscholar Student_Id: ");
            dayscholar.StudentId = int.Parse(Console.ReadLine());
            Console.Write("Dayscholar Name: ");
            dayscholar.Name = Console.ReadLine();

            
            Resident resident = new Resident();
            Console.Write("Resident Student_Id: ");
            resident.StudentId = int.Parse(Console.ReadLine());
            Console.Write("Resident Name: ");
            resident.Name = Console.ReadLine();

            
            Console.WriteLine("\nStudent Details:");
            dayscholar.ShowDetails();
            resident.ShowDetails();
            Console.Read();
        }
    }

}

