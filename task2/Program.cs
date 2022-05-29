using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook();
            notebook1.Name = "Notebook";
            notebook1.BrandName = "Lenovo";
            notebook1.Price = 4299;

            Notebook notebook2 = new Notebook();
            notebook2.Name = "Notebook";
            notebook2.BrandName = "DELL";
            notebook2.Price = 2929;

            Notebook notebook3 = new Notebook();
            notebook3.Name = "Notebook";
            notebook3.BrandName = "Acer";
            notebook3.Price = 3799;

            Notebook notebook4 = new Notebook();
            notebook4.Name = "Notebook";
            notebook4.BrandName = "MSI";
            notebook4.Price = 2599;

            Notebook notebook5 = new Notebook();
            notebook5.Name = "Notebook";
            notebook5.BrandName = "HP";
            notebook5.Price = 3999;


            Notebook[] arr = new Notebook[5] { notebook1, notebook2, notebook3, notebook4, notebook5 };
            Console.WriteLine("Minimum qiymet daxil edin:");
            int minPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Maximum qiymet daxil edin:");
            int maxPrice = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Price > minPrice && arr[i].Price < maxPrice)
                {
                    count++;
                    Console.WriteLine(arr[i].BrandName);
                }

            }
            if (count == 0)
                Console.WriteLine("Bu araliqda mehsul yoxdur");
        }
    }
}
