using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyI.Week1.Ado
{
    class EmployeeAdoRepository
    {
        const string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;" +
                                         "Initial Catalog = AcademyFDemos;" +
                                         "Integrated Security = true";
        public List<Employee> Fetch()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Aprire connessione
                    connection.Open();

                    // Definire i comandi
                    SqlCommand command = new SqlCommand();
                    command.CommandType = System.Data.CommandType.Text;  // definisco il tipo di comando
                    command.Connection = connection;                     // associo al comando la connessione
                    command.CommandText = "select * from dbo.Employees"; // scrivo il comando - query

                    SqlDataReader reader = command.ExecuteReader();

                    List<Employee> employees = new List<Employee>();

                    while (reader.Read())
                    {
                        Employee emp = new Employee();
                        emp.Id = Convert.ToInt32(reader["Id"]);  //(int)reader["Id"];
                        emp.Code = (string)reader["EmployeeCode"];
                        emp.FirstName = (string)reader["FirstName"];
                        emp.LastName = (string)reader["LastName"];

                        employees.Add(emp);
                    }

                    return employees;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Employee GetById(int id)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "select * from dbo.Employees where Id = @id";
                    command.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = command.ExecuteReader();

                    Employee emp = new Employee();

                    while(reader.Read())
                    {
                        emp.Id = (int)reader["Id"];
                        emp.Code = (string)reader["EmployeeCode"];
                        emp.FirstName = (string)reader["FirstName"];
                        emp.LastName = (string)reader["LastName"];
                    }
                    return emp;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(Employee emp)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "insert into dbo.Employees values(@code, @firstName, @lastName)";
                    command.Parameters.AddWithValue("@code", emp.Code);
                    command.Parameters.AddWithValue("@firstName", emp.FirstName);
                    command.Parameters.AddWithValue("@lastName", emp.LastName);

                    command.ExecuteNonQuery(); // Non è una lettura, non riturna nulla
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Employee emp) // volendo anche solo l'id
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "delete dbo.Employees where Id = @id";
                    command.Parameters.AddWithValue("@id", emp.Id); // oppure solo id se viene passato

                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Employee emp) // string code, string firstname, string lastname
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "update dbo.Employees set EmployeeCode = @code, " +
                                            "FirstName = @firstName, LastName = @lastName where Id = @id";

                    command.Parameters.AddWithValue("@code", emp.Code);
                    command.Parameters.AddWithValue("@firstName", emp.FirstName);
                    command.Parameters.AddWithValue("@lastName", emp.LastName);

                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
