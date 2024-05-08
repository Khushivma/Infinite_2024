
using System;
using System.Data;
using System.Data.SqlClient;

namespace Assessment01
{
    class Program
    {
        public static SqlConnection con = null;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Name:");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary:");
            decimal empSal = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Type:");
            string empType = Console.ReadLine();

            AddEmployee(empName, empSal, empType);
            Console.ReadLine();
        }


        public static SqlConnection getConnection()
        {
            con = new SqlConnection("Data Source=ICS-LT-57L96V3;Initial Catalog=Employeemanagement;Integrated Security=True");
            con.Open();
            return con;
        }


        public static void AddEmployee(string empName, decimal empSal, string empType)
        {
            try
            {

                using (SqlConnection connection = getConnection())
                {

                    SqlCommand command = new SqlCommand("AddEmployee", connection);
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@EmpName", empName);
                    command.Parameters.AddWithValue("@Empsal", empSal);
                    command.Parameters.AddWithValue("@Emptype", empType);


                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Employee added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No rows affected. Employee not added.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
