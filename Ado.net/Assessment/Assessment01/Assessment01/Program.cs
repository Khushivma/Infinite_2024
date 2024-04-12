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
            // Prompt the user to enter employee details
            Console.WriteLine("Enter Employee Name:");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary:");
            decimal empSal = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Type:");
            string empType = Console.ReadLine();

            // Call the AddEmployee method with user-provided details
            AddEmployee(empName, empSal, empType);
            Console.ReadLine();
        }

        // Method to establish database connection
        public static SqlConnection getConnection()
        {
            con = new SqlConnection("Data Source=DESKTOP-H055PGN;Initial Catalog=Employeemanagement;Integrated Security=True");
            con.Open();
            return con;
        }

        // Method to add an employee
        public static void AddEmployee(string empName, decimal empSal, string empType)
        {
            try
            {
                // Establish database connection
                using (SqlConnection connection = getConnection())
                {
                    // Create a SqlCommand object for the stored procedure
                    SqlCommand command = new SqlCommand("AddEmployee", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters for the stored procedure
                    command.Parameters.AddWithValue("@EmpName", empName);
                    command.Parameters.AddWithValue("@Empsal", empSal);
                    command.Parameters.AddWithValue("@Emptype", empType);

                    // Execute the stored procedure
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if rows were affected
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
