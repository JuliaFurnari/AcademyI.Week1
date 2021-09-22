using System;
using System.Collections.Generic;

namespace AcademyI.Week1.Ado
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeAdoRepository repository = new EmployeeAdoRepository();

            try
            {
                List<Employee> employees = repository.Fetch();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
