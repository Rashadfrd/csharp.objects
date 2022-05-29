using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Notebook notebook1 = new Notebook();
                notebook1.Name = "Notebook";
                notebook1.BrandName = "Lenovo";
                notebook1.Price = 2430;

                Notebook notebook2 = new Notebook();
                notebook2.Name = "Notebook";
                notebook2.BrandName = "HP";
                notebook2.Price = 3299;




                Console.WriteLine($"{notebook2.Name} {notebook2.Price} {notebook2.BrandName}");
            }

        }
    }
}
