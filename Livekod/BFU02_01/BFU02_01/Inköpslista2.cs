using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFU02_01
{
    public class Inköpslista2
    {
        Product[] Products;
        internal void Run()
        {
            Products = new Product[]
            {
                new Product("Mjölk",14.50),
                new Product("Bröd",22.95),
                new Product("Ost",89.90),
                new Product("Smör",49.50)
            };
            SkrivUtLista();
        }
        private void SkrivUtLista()
        {
            double sum = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine($"{Products[i].Namn} {Products[i].Pris}:-");
                sum += Products[i].Pris;
            }
            Console.WriteLine($"Summa:{Math.Round(sum, 2)}");
            double average = Math.Round(sum / Products.Length, 2);
            Console.WriteLine($"Medelpris: {average}");
        }

    }
}
