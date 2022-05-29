using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Brand = "Wolkvagen";
            car1.Model = "Touareg";
            car1.CurrentFuel = 10;
            car1.FuelFor1km = 2;
            car1.Millage = 20000;

            Drive(car1);
            Console.WriteLine(car1);
        }
        static void Drive(Car car)
        {
            Console.WriteLine("Nece km getmek istediyinizi daxil edin:");
            int neededkm = int.Parse(Console.ReadLine());
            if (car.CurrentFuel >= car.FuelFor1km * neededkm)
            {
                car.Millage += neededkm;
                car.CurrentFuel -= car.FuelFor1km * neededkm;
                Console.WriteLine($"Masinda {neededkm} km-lik yolu qet edecek benzin movcuddur. Yol qet edildikden sonra benzin {car.CurrentFuel} l ve millage {car.Millage} km olacaqdir");
            }
            else
                Console.WriteLine("Benzin catismir");
        }
    }
}
