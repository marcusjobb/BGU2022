using System;

namespace Hemtenta
//Ett spel som slumpar fram ett tal mellan 0-100 där spelaren får maximalt tio gånger på
//sig att gissa vilket tal det är. Storyn är att det är 100 boxar där en av dem
//innehåller en diamant och resten bara en vanlig sten.
//Programmet säger "Hej!" och ber spelaren gissa på ett värde 1 till 100.
//Programmet slumpar fram ett tal 1-100. Spelaren gissar första gången av maximalt tio.
//Om spelaren gissar för lågt svarar programmet att talet är för lågt och ber spelaren gissa igen.
//Om spelaren gissar för högt svarar programmet att talet är för högt och ber spelaren gissa igen.
//Om spelaren gissar rätt säger programmet "Grattis! Du vann!"
//Efter en rätt gissning och/eller maximalt tio felaktiga avslutas spelet dvs programmet kör en loop max tio gånger
//och om spelaren gissar rätt inom de tio gångerna ska loopen avslutas.

{
    class Program
    {
        //Metod som läser in spelarens gissning och gör om den från en string till en int.
        public int GuessNumber()
        {
            //Om spelaren skriver in bokstäver svarar programmet att det ska skrivas med siffror istället.
            bool siffra = false;

            string gissning = Console.ReadLine();
                siffra = int.TryParse(gissning, out int gissningTal);

            if (siffra == false)

                {
                    Console.WriteLine("Skriv in ett tal med siffror.");
                
                }
            

            
            return gissningTal;
        }

        private static void Main(string[] args)
        {
            

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(" CHANS ATT VINNA DIAMANTEN!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("Hej! Här är 100 boxar, numrerade 1-100. I en av dem ligger en diamant. I de andra ligger det bara en vanlig sten. Du har tio chanser på dig att gissa rätt.");


            //För att få datorn att välja ett slumptal använder jag en randomerare.

            Random randomerare = new Random();

            //Jag vill att den ska slumpa ett tal mellan 0-101, dvs 1-100 och anger därför 101
            //som högsta tal.

            int hemligtTal = randomerare.Next(0, 101);
            Console.WriteLine();

            //Jag vet inte hur många gånger loopen ska köras, bara att det är max tio gånger
            //och därför använder jag en while-loop

            //i står här för antal gjorda försök/gissningar och repeat för antal tillåtna försök.

            int i = 0;
            int repeat = 10;

            int gissningTal;

            bool found = false;

            while (found == false && i < repeat)
            //För att få Console.ReadLine (string) till en int använder jag TryParse. 
            {
                //Spelaren skriver in sin gissning
                i++;

                //Kallar på metoden och läser in gissningen.
                
                Program m1 = new Program();
                
                gissningTal = m1.GuessNumber();


                //Talet som skrivs in är antingen för högt, för lågt eller rätt.

                if (hemligtTal < gissningTal)
                {
                    if (i < repeat)
                    {
                        Console.WriteLine("Du gissade för högt. Boxen med diamanten har ett lägre nummer. Försök igen.");
                    }

                }
                else if (hemligtTal > gissningTal)

                {
                    if (i < repeat)
                    {
                        Console.WriteLine("Du gissade för lågt. Boxen med diamanten har ett högre nummer. Försök igen.");
                    }

                }

                else
                {
                    Console.WriteLine("Grattis! Du hittade diamanten!");
                    found = true;


                }



            }
            //Spelet fortsätter så länge spelaren inte gissar rätt och samtidigt inte använt sina tio gissningar. Sspelet tar slut när antingen gissningarna
            //är slut eller gissningen är rätt inom de tio försöken.

            if (found == false)
            {
                Console.WriteLine("Åh nej! Dina gissningar är slut! Du hittade inte diamanten men en vanlig sten kan ju vara fin den också. Vem vet, den kanske går att slipa till en diamant?");
            }





        }
    }
   
}
//Pseudokod

//START
    //Spel mot datorn. 
        //Hemligt framslumpat tal 1-100
        //Tio gissningar
            //Skriv gissning
                //Om gissning för hög eller låg
                    //spelet fortsätter om gissningar <10
                //Om gissning rätt och gissningar <=10
                    //spelet slut
                //Om gissning fel och gissningar =10
                    //spelet slut


//SLUT



