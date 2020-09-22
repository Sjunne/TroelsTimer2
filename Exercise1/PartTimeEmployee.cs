using System.Buffers.Text;

namespace Exercise1
{
    public class PartTimeEmployee : Employee
    {
        private double hourlyWage { get; set; }
        private int hoursPerMonth { get; set; }

        public PartTimeEmployee(string name, double hourlyWage, int hoursPerMonth) : base(name)
        {
            this.hourlyWage = hourlyWage;
            this.hoursPerMonth = hoursPerMonth;
        }


        public override double GetMonthlySalary()
        {
            return hoursPerMonth * hourlyWage;
        }
    }
}