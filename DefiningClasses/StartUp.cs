using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string data = Console.ReadLine();
                string model = data.Split()[0];
                double fuelAmount = double.Parse(data.Split()[1]);
                double fuelConsumption = double.Parse(data.Split()[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(car);
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string carModel = command.Split()[1];
                double amountKm = double.Parse(command.Split()[2]);

                Car carToDrive = cars.First(c => c.Model == carModel);
                carToDrive.Drive(amountKm);
            }
            foreach (Car item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelledDistance}");
            }
        }
    }
}
