namespace Exercise1
{
    public abstract class Employee
    {
        public string name { get; set; }

        protected Employee(string name)
        {
            this.name = name;
        }

        public abstract double GetMonthlySalary();

    }
}