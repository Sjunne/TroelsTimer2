using System;
using System.Buffers;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        { 
            var cars = RandomCar(10);
            var findAllBlue = cars.FindAll(a => a.color.Equals("blue"));
            var findEngineSize = cars.FindAll(d => d.EngineSize > 4);
            var findfueldEconomy = cars.FindAll(f => f.FuelEconomy > 50);
            
            findAllBlue.ForEach(c => Console.WriteLine(c.ToString()));
            findEngineSize.ForEach(e => Console.WriteLine(e.ToString()));
            findfueldEconomy.ForEach(g => Console.WriteLine(g.ToString()));
        }

        private static List<Car> RandomCar(int amount)
        {
            Random rnd = new Random();
            List<string> colors = new List<string>() {"blue", "red", "white", "yellow", "green"};
            List<int> engineSize = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            List<int> fuelEco = new List<int>() {30, 40, 50, 60, 70, 80, 90};
            List<bool> manuel = new List<bool>() {true, false};
            List<Car> carList = new List<Car>();


            for (int i = 0; i < amount; i++)
            {
                carList.Add(new Car(colors[rnd.Next(colors.Count)], engineSize[rnd.Next(engineSize.Count)],
                    fuelEco[rnd.Next(fuelEco.Count)], manuel[rnd.Next(manuel.Count)]));
            }

            return carList;
        }
    }
}