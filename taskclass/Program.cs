using System;

namespace taskclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook();
            notebook1.Name = "HP";
            notebook1.BrandName = "Pavilion";
            notebook1.Price = 1500;

            Notebook notebook2 = new Notebook();
            notebook2.Name = "Lenevo";
            notebook2.BrandName = "IdeaPad";
            notebook2.Price = 2000;

            Notebook notebook3 = new Notebook();
            notebook3.Name = "Dell";
            notebook3.BrandName = "Gaming";
            notebook3.Price = 2200;

            Notebook[] notebook = { notebook1, notebook2, notebook3 };
            Notebook[] priceNotebook = PriceNotebook(notebook);
            foreach (var item in priceNotebook)
            {
                Console.WriteLine($"Name:   {item.Name}     Model:  {item.BrandName}      Price:   {item.Price}");
            }
                 
        }
        static Notebook [] PriceNotebook(Notebook [] arr)
        {
            int count = 0;
            double maxprice = 2100;
            double minprice = 1100;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i].Price<maxprice && arr[i].Price > minprice)
                {
                    count++;
                }
            }
            Notebook[] newNotebook = new Notebook[count];
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Price < maxprice && arr[i].Price > minprice)
                {
                    newNotebook[k] = arr[i];
                }
            }

            return newNotebook;


        }
    }
}
