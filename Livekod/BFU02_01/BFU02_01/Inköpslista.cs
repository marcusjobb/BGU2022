using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFU02_01
{
    public class Inköpslista
    {
        string[] items;
        double[] prices;
        public void Run()
        {
            items = new string[] { "Mjölk", "Bröd", "Ost" ,"Smör"};
            prices = new double[] { 14.50, 22.95, 89.90 ,49.50};
            
            SkrivUtLista();
        }

        private void SkrivUtLista()
        {
            double sum = 0;
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{items[i]} {prices[i]}:-");
                sum += prices[i];
            }
            Console.WriteLine($"Summa:{Math.Round(sum,2)}");
            double average = Math.Round(sum / items.Length,2);
            Console.WriteLine($"Medelpris: {average}");
        }
    }
}
