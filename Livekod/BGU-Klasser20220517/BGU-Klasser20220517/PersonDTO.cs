namespace BGU_Klasser20220517;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// DTO = Data Transfer Object
// Den innehåller data som skickas mellan klient och servern 
// eller mellan klasser
// POCO = Plain Old Class Object
// Den gör standard data hantering men inget avancerat
internal class PersonPOCO
{
    public string Name { get; set; } // Property / Egenskap
    public string Lastname { get; set; } // Property / Egenskap
    public int Age { get; set; } // Property / Egenskap
    public void PrintName() // Tar emot referens till var i minnet objektet finns
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("+ " + Name + " " + Lastname + ", " + Age);
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();
    }
}
