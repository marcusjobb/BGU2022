namespace BGU20220524_Arv_och_metoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Instrument
{
    // Virtual = Jag tillåter att andra ersätter metoden, men det är inte ett krav
    // Abstract = Jag kräver att man skapar metoden
    public abstract void Play();
    public string Name { get; set; } = "";
}
public class Piano: Instrument
{
    // Override = Jag vill ersätta metoden i huvudklassen
    public override void Play()
    {
        Console.WriteLine("Pling!");
    }
}

public class Trumpet : Instrument
{
    // Override = Jag vill ersätta metoden i huvudklassen
    public override void Play()
    {
        Console.WriteLine("Tuuuut!!!");
    }
}
