using System;
using System.Collections.Generic;
using System.Text;

namespace gcBonus16
{
    class CarApp
    {
        List<Car> cars = new List<Car>();

        public CarApp() { }

        public void GetInfo()
        {
            Console.Write("How many cars would you like to enter?: ");
            int numberInput = int.Parse(Console.ReadLine());

            for (int j = 0; j < numberInput; j++)
            {
                Console.WriteLine();
                Console.WriteLine("Enter information about Car Number " + (j + 1) + " below to add it to the list.");

                Console.Write("Make: ");
                string make = Console.ReadLine();

                Console.Write("Model: ");
                string model = Console.ReadLine();

                Console.Write("Year: ");
                int year = int.Parse(Console.ReadLine());

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                cars.Add(new Car(make, model, year, price));
            }
        }

        public void PrintList()
        {
            for (int j = 0; j < cars.Count; j++)
            {                             
                Console.WriteLine(cars[j].ToString());
            }
        }


    }
}
