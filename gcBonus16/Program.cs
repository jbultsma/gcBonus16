using System;

namespace gcBonus16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus admin Console!");
            Car c = new Car();
            
            Run();            
        }  
        
        public static void Run()
        {
            CarApp carApp = new CarApp();

            carApp.GetInfo();

            Console.WriteLine();
            Console.WriteLine("...");
            Console.WriteLine();
            Console.WriteLine("Current Inventory:");
            Console.WriteLine();

            carApp.PrintList();
        }
    }
}
