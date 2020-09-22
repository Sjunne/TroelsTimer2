using System.Collections;
using System.Collections.Generic;

namespace Exercise1
{
    public class Company
    {
        private List<Employee> _employees = new List<Employee>();

      

        public double GetMonthySalaryTotal()
        {
            double salary = 0;
            for (int i = 0; i < _employees.Count; i++)
            {
                salary += _employees[i].GetMonthlySalary();
            }

            return salary;
        }

        public void EmployNewEmployee(Employee newEmployee)
        {
            _employees.Add(newEmployee);
        }
    }
}