using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gissningslek
{
    internal class Tävla
    {
        int slumptal; //Variabel som innehåller tävlingens slumptal
        int gissning; //Variabel som har gissningssiffran
        int counter; //Variabel som håller ordning på antal gissningar

        internal void TaFramEttSlumptal() //Metod som tar fram ett slumptal mellan 0 och 100
        {
            Random r = new Random();
            slumptal = r.Next(1,101);

        }
        internal void GissningsRundor() //Metod som frågar efter en gissning och kör gissningsrundor tills det är rätt/tid ute
        {
            Console.WriteLine("Gissa ett heltal mellan 1 och 100.");

            for (counter = 1; counter < 11; counter++)

            { 

                    KollaGissningen(); 
                    
                     if (gissning == slumptal) //if-satsen jämför gissningen med slumptalet och skriver lämplig kommenter
                     {
                        Console.WriteLine("Jippiii, du gissade rätt!!!!");
                        HurBraVarGissnigen(counter);
                     break;
                     }
                     //anropa "korrekt"metod


                     else if (gissning < slumptal)
                     {
                          Console.WriteLine("Åhh, du behöver ta i lite mer.");
                     }


                     else
                     {
                          Console.WriteLine("Det var kanske i högsta laget, testa något mindre.");
                     }
            }
            if (counter == 11)
            {
                 Console.WriteLine("Åh nej vad tråkigt, dina försök är slut.");
            }

        }
        internal int KollaGissningen() // tar in gissningen och kollar att det är ett tal mellan 1 och 100
        {
            while (true)
            {
                string gissningText = Console.ReadLine();
                if (int.TryParse(gissningText, out gissning))
                {
                    if (gissning < 1 || gissning > 100)
                    {
                        Console.WriteLine("Hur svårt kan det va??? Mellan 1 och 100!");
                    }
                    else
                    {
                        return gissning;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Hoppsan, det var inte en siffra. Gissa på en siffra!");
                    //denna rad skrivs då det inte är en siffra men den ligger kvar i whileloopen 
                    //och räknaren räknar inte upp dvs man får 10 gissningar+icketalsinmatningarna
                }
            }
        }
internal void HurBraVarGissnigen(int antalFörsök) //Metod ger olika grattissvar. Valiabeln antalFörsök är gissningens nr.
{ 
string svar;
    switch (antalFörsök)
    {
            case 1: svar = "Wow, duklarade det på första försöket. Bravo!!!"; break;
            case 2: svar = "Träff!! På andra försöket, det var bra!";   break;
            case 9: svar = "Det var inte mycket till marginal, bravo!"; break;
            case 10: svar = "Det var på håret, rätt på sista försöket!";  break;
            default: svar = "Rätt på försök nummer " + counter; break;
    }
    Console.WriteLine(svar);
}
    }
}


