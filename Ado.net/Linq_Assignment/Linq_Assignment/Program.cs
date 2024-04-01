using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> empList = new List<Employee>
            {

            new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
            new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
            new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
            new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
            new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
            new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
            new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
            new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
            new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
            new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }

            };

            // 1. Display a list of all the employees who have joined before 1/1/2015

            var before15 = empList.Where(Employee => Employee.DOJ < new DateTime(2015, 1, 1));
            Console.WriteLine("1- Employees who have joined before 1/1/2015:");
            foreach (var Employee in before15)
            {
                Console.WriteLine(Employee.FirstName + " " + Employee.LastName);
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            // 2. Display a list of all the employees whose date of birth is after 1/1/1990

            var after90 = empList.Where(Employee => Employee.DOB > new DateTime(1990, 1, 1));
            Console.WriteLine("\n2- Employees DOB is after 1/1/1990:");
            foreach (var Employee in after90)
            {
                Console.WriteLine(Employee.FirstName + " " + Employee.LastName);
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            // 3. Display a list of all the employees whose designation is Consultant and Associate

            var consultantsAndAssociates = empList.Where(Employee => Employee.Title == "Consultant" || Employee.Title == "Associate");
            Console.WriteLine("\n3- Employees whose designation is Consultant and Associate:");
            foreach (var e in consultantsAndAssociates)
            {
                Console.WriteLine(e.FirstName + " " + e.LastName);
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            // 4. Display total number of employees

            Console.WriteLine("\n4- Total number of employees: " + empList.Count);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            // 5. Display total number of employees belonging to “Chennai”

            var chennCount = empList.Count(Employee => Employee.City.Equals("Chennai"));
            Console.WriteLine("\n5- Total number of employees belonging to Chennai: " + chennCount);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            // 6. Display highest employee id from the list

            int maxEmpID = empList.Max(Employee => Employee.EmployeeID);
            Console.WriteLine("\n6- Highest employee ID: " + maxEmpID);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            // 7. Display total number of employees who have joined after 1/1/2015

            var after15 = empList.Count(Employee => Employee.DOJ > new DateTime(2015, 1, 1));
            Console.WriteLine("\n7- Total number of employees who have joined after 1/1/2015: " + after15);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");


            // 8. Display total number of employees whose designation is not “Associate”

            var notAss = empList.Count(Employee => Employee.Title != "Associate");
            Console.WriteLine("\n8- Total number of employees whose designation is not Associate: " + notAss);
            var notAssEmp = empList.Where(x => x.Title != "Associate");
            foreach (var v in notAssEmp)
            {
                Console.WriteLine(v.FirstName + " " + v.LastName + " ->" + v.Title);
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");


            // 9. Display total number of employees based on City

            var boc = empList.GroupBy(Employee => Employee.City);
            Console.WriteLine("\n9- Total number of employees based on City:");
            foreach (var group in boc)
            {
                Console.WriteLine(group.Key + ": " + group.Count());
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            // 10. Display total number of employees based on city and title


            var cat = empList.GroupBy(x => new { x.City, x.Title });
            Console.WriteLine("\n10- Total number of employees based on City and Title:");
            foreach (var group in cat)
            {
                Console.WriteLine(group.Key.City + " - " + group.Key.Title + ": " + group.Count());
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");


            // group.Key.City->   retrieving the city name for the group.
            // group.Key.Title->  retrieving the job title for the group.


            // 11. Display total number of employees who is youngest in the list

            var yDOB = empList.Max(Employee => Employee.DOB);
            var yEmp = empList.Where(x => x.DOB.Equals(yDOB));
            Console.WriteLine();
            Console.Write("11. Youngest employee: ");
            foreach (var v in yEmp)
            {
                Console.WriteLine(v.FirstName + " " + v.LastName);
            }

            Console.WriteLine("***********************************************************************************************************************");
            Console.Read();
        }
    }
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }
}
    

