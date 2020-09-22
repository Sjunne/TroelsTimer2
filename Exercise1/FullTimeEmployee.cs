namespace Exercise1
{
    public class FullTimeEmployee : Employee
    {
        private double monthlySalary { get; set; }

        public FullTimeEmployee(string name, double monthlySalary) : base(name)
        {
            this.monthlySalary = monthlySalary;
        }

        public override double GetMonthlySalary()
        {
            return monthlySalary;
        }
    }
}