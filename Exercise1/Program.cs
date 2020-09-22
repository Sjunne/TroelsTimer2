using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Maria = new FullTimeEmployee("Maria", 4000);
            Employee Mattias = new PartTimeEmployee("Mattas", 350,80);
            Company company = new Company();
            
            company.EmployNewEmployee(Maria);
            company.EmployNewEmployee(Mattias);

            Console.WriteLine(company.GetMonthySalaryTotal());
        }
    }
}