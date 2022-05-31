using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Älvan
{

    internal class Spel
    {
        public void Älva()
        {

            // Om du startar en loop här och avslutar den efter att spelet slutat
            // kan du fråga spelaren om de vill spela igen, om spelaren vill spela 
            // igen så låter du loopen köra, annars kör du break;
            Console.Clear();
            Console.WriteLine("+--------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("|Välkommen till den megiska älvaskogen! När du träffar en älva och du blir ombedd att gissa hennes ålder,|");
            Console.WriteLine("|då kommer du att ha turen och du kan gifta dig med hon                                                  |");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------------+");
            Console.WriteLine();
            Console.WriteLine();

            // Här skapar man proceduren för att skapa det hemliga numret
            Random random = new Random();
            int slumpTal = random.Next(1, 101);
            int antalGissningar = 1;// Variablen tilldelas värdet 1 
            int gissnininggräns = 10;// Man har bara 10 forsök


            Console.WriteLine("Du har pricis träffat en älva, gissar hennes ålder");   // Man visar på skärmen medelandet" Du har träffat en älva och gissar hennes åldern
            Console.WriteLine("Skriv in henne åldern, ange ett tal mellan 1 och 100:");// Här visar man på skärmen " Skriv henne åldern mella 1 och 100


            int åldern = siffra();
            // Skapa en metod som returnerar en int och kontrollerar att man inte skrivit fel

            do //Gör det som står nedan...
            {
                if(åldern > slumpTal)// Om talet är högre en slumptal
                {
                    Console.WriteLine("Du gissade fel. Hon är inte så äldre, gissa en lägre tal !");// Här visar man på skärmen att älvan är inte så äldre och gissa ett lägre tal!
                }
                else if(åldern < slumpTal) //Om talet är mindre en slumptal 
                {
                    Console.WriteLine("Du gissade fel. Hon är inte så ung, gissa en högre tal!");//Här visar man på skärmen att älvan är inte så ung och gissa ett högre tal!
                }
                else// När man gissar älvan åldern 
                {
                    Console.WriteLine("Grattis du ska gifta med henne! Du gissade rätt åldern !");// Det visar på skärmen "Grattis du kommer att gifta med henne! + du gissade rätt ålder.
                    Console.WriteLine("Antal gissningar:" + antalGissningar + " " + " " + "Hemlig tal är:" + slumpTal);// Här visar man på skärmen hur många gånger har man försökt gissa åldern och
                                                                                                                       // vilken är hemlig tal
                    Console.ReadLine();
                    break;// Här stoppar loopen och går ut if else if else
                }

                åldern = siffra();// Här omvandlar det en string i en int
                antalGissningar++;                          // Ökar antalet försök

            }
            while(antalGissningar != gissnininggräns);                    // Medan Loopen fortsätter så länge antalet gissningar inte är lika med "guessLimit".

            if(antalGissningar == gissnininggräns && åldern != slumpTal) //Gemföra om antal gissningar är lika med gissnininggräns men
                                                                         //tal är inte lika med slumptal.

            {
                Console.WriteLine("Jag är ledsen, men älvan gick bart för att du inte gissade hennes åldern");// Skriva ut att älvan gick barta för att gissade inte ålder 
                Console.WriteLine("Nästa gång du träffar henne kommer du att ha mer tur");                   // Skriva ut att kan man träffa älvan en annan gång och tenta igen
                Console.ReadLine();                                                                          // Läs input 

            }
            else if(antalGissningar == gissnininggräns && åldern == slumpTal)// Här gemföra om antalgissningar är lika med gissninggräns och
            {                                                              // & tal är lika med slumptal.

                Console.WriteLine("Grattis! Du gissade rätt!");          // Skriva ut att man har gissat hemlig tal
                Console.WriteLine("Antal gissningar:" + antalGissningar);// Skriva ut hur många gånger har försök gissat 
                Console.ReadLine();                                      //Läs input

            }

            // Det enda kvar i koden är nu att fråga
            // "Vill du spela igen (j/n)"
            // Här slutar loopen du startade i början av spelet

            while(åldern != slumpTal && antalGissningar != gissnininggräns) ; //Loopen fortsätter så länge det gissade talet inte är lika med det slumpade talet och
                                                                              //antalGissningar inte är lika gissninggräns
        }

        // Skapa metodhuvud
        private int siffra()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int nummer))
                {
                    return nummer;// nummer är OK

                }
                else
                {
                    Console.WriteLine("Hej Mr. Don Giovanni om du vill gifta dig, behöver du att ange en siffra");
                    // nummer är bokstäver
                }
            }
        }
    }
}
        