namespace Exercise4
{
    public class Car
    {
        public string color { get; set; }
        public int EngineSize{ get; set; }
        public int FuelEconomy{ get; set; }
        public bool IsManuelShift{ get; set; }

        public Car(string color, int engineSize, int fuelEconomy, bool isManuelShift)
        {
            this.color = color;
            EngineSize = engineSize;
            FuelEconomy = fuelEconomy;
            IsManuelShift = isManuelShift;
        }

        public override string ToString()
        {
            return
                $"color is {color} EngineSize is {EngineSize} Fuel Economy is {FuelEconomy} Manuel?? {IsManuelShift}";
        }
    }
}