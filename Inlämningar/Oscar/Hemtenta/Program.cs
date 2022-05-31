namespace FotbollsTävling 
{ 
    public static class FotbollstävlingProgram
    { 
        public static void Main ()
        {

            

            Random random = new Random(); // En klass som får fram ett slumpat tal

            // Deklarerar variabler 
            int min = 1; // mista värdet det slumpade talet kan få
            int max = 100; // högsta värdet det slumpade talet kan få
            int guess = 0; // gissningen
            int number = random.Next(min, max); //variabeln "number" blir ett slumpat tal mellan "min" och "max" i detta fallet mellan 1 och 100.
            int guesses = 0; //Håller koll på hur många gånger personen har gissat
        
            //Console.WriteLine(number); //Har lagt nummer här för att veta vad det slumpade talet är när jag testar programmet.
            Console.WriteLine("Du är med i en fotbollstävling med chans att vinna 1 000 000 kr, det ända du behöver göra är att träffa " +
                                "en slumpad låda med nummer mellan " + min + " - " + max + ", du har 10 skott på dig, Lycka till");
            TomRad();
                Console.WriteLine("Skjut ditt första skott:");
            

            // Programmet startar och förklarar vad uppdraget är.
            guess = GetGuess();


            while (guess != number) //Om svaret är fel så startar en while loop tills svaret är rätt eller personen har gissat fel 10 ggr
            {

                if (guess < min || guess > max) // Om personen skriven in ett för lågt eller för högt tal så talar programmet om det för personen och ber personen skriva in ett nytt nummer
                {
                    TomRad();
                    Console.WriteLine("Du måste skjuta på lådorna mellan " + min + " - " + max + " dom andra lådorna är inte med i tävlingen.");
                    
                }
                else if (guess > number) //Om personen skriver in ett nummer som är högre än rätt svar så säger programmet till personen att gissa lägre och lägger till ett försök
                {
                    TomRad();
                    Console.WriteLine("Ajajaj, det var inte rätt men testa ett lägre nummer");
                    guesses++;
                    
                }
                else if (guess < number)//Om personen skriver in ett nummer som är lägre än rätt svar så säger programmet till personen att gissa högre och lägger till ett försök
                {
                    TomRad();
                    Console.WriteLine("Ojojoj, det var tyvärr fel men testa att skjuta på ett högre nummer");
                    guesses++;
                    
                }


             guess = GetGuess ();

                if (guesses == 10) // Om personen har gissat 10 gånger så stängs programet av om programmet berättar att man har förlorat och vad rätt svar var
                {
                    TomRad();
                    Console.WriteLine("Du har tyvärr redan bränt alla dina 10 försök, rätt låda var " + number + " men tack för att du deltog");
                    Environment.Exit(1);
                }
            }
            
            
            TomRad(); //Om gissningen var rätt så berättar programmet att man hade rätt och på hur många försök sedan avslutas programmet.
            Console.WriteLine("Ajajaj det var tyvärr... eller vänta lite, det var ju rätt... eh grattis till 1 000 000kr antar jag... min chef kommer döda mig");
            TomRad();
            Console.WriteLine("Du sköt " + guesses + " skott.");



            // Metoder
            void TomRad()
            {
                Console.WriteLine();
            } // skapar en tom rad
            int GetGuess ()
        {
            guess = 0;
            while (!int.TryParse(Console.ReadLine(), out guess)) //Kollar så att personen skriver in en siffra

            {
                Console.WriteLine("Du måste träffa en av lådorna med ett nummer mellan " + min + " - " + max);

            }
            return guess;


        } // Ber personen gissa och kollar så att det är en int
        }
    }

}

