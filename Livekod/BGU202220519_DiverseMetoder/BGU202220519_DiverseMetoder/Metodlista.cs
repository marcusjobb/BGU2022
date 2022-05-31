namespace BGU202220519_DiverseMetoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Metodlista
{
    internal void Hello()
    {
        Console.WriteLine("Hej på dig!");
    }

    internal void HelloName()
    {
        Console.WriteLine("Vad heter du?");
        string name = Console.ReadLine();
        Console.WriteLine($"Hej {name}");
    }

    internal bool IsUserEighteen()
    {
        Console.WriteLine("Hur gammal är du?");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int age))
        {
            bool isEighteen = age == 18;
            return isEighteen;
        }
        else
        {
            Console.WriteLine("Det där var inte ett tal!");
        }
        return false;
    }
}
