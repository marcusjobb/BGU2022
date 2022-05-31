namespace GissningsSpel
{
    internal class GissningsSpel
    {
        public static void Main(string[] args)
        {
            bool gissarätt = false;                   //Spel''gissnings''loopen
            Random lösenord = new Random();           // Slumpat nummer
            int min = 1;                              // Minsta nummret som kan genereras
            int max = 100;                            // Största nummret som kan genereras
            int randomNum = lösenord.Next(min, max + 1);   // Generera slumpat nummer / knapp / lösenord inom mina satta ramar med min o max.  Max nummret är exkluderat så sätter ''max + 1'' för att fixa det inom nummergenereringen.
            int försök = 0;                                // En int för att definera antal gissningsförkök
            int Gissning = 0;                              // Användarinputen, alltså gissningen.


            // Nedan är bara spelstory + instruktion till användaren som printas ut.
            Console.WriteLine("Du har äntligen nått skattkammaren, men för att nå den eftertraktade och mystiska skatten så måste du gissa på rätt knapp!");
            Console.WriteLine("Det finns 100 knappar nummrerade " + min + "-" + max + " från vänster till höger och du har endast 10 försök på dig eftersom rummet fylls med lite mer vatten varje gång du gissar fel!");
            Console.WriteLine("Gissar du rätt så når du skatten och hamnar i säkerhet!");



            while(!gissarätt)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Vilken knapp gissar du på?");
                Console.WriteLine("Gissa mellan " + min + " och " + max + ".");


                try
                {
                    Gissning = Convert.ToInt32(Console.ReadLine());    // Input string till int (sålänge det är en input som blir godkänd av checken ''Numerisk'')


                    försök++;                 // Räkna gissningar
                    if(försök > 9)              // Gissningslimit
                    {
                        FörlustMetod();           // Om gissningslimiten är nådd, kalla på förlustmetoden.
                    }

                    if(Gissning > randomNum)
                    {
                        Console.WriteLine("Du gissade för långt till höger, du hör en vattensluss öppnas och mer vatten forsar in i rummet!");
                    }
                    else if(Gissning < randomNum)
                    {
                        Console.WriteLine("Du gissade för långt till vänster, du hör en vattensluss öppnas och mer vatten forsar in i rummet!");
                    }
                    else
                    {
                        Console.WriteLine("Du gissade rätt! Vattnet börjar sakta försvinna och du ser hur den stora skattkammardörren börjar öppnas, du glimtar guld och mystiska artefakter i öppningen. DU HAR VUNNIT!");
                        gissarätt = true;
                    }


                }

                catch                                                            //Catch för att stoppa programkrasch vid ickenumerisk input.
                {
                    Console.Write("Du måste gissa på ett nummer!  ");

                }



            }
            Console.WriteLine("Grattis!");
            Console.WriteLine("Gissningar: " + försök);

            Console.ReadKey();


        }
        static void FörlustMetod()
        {

            Console.WriteLine("Rummet blev helt fyllt med vatten och drunknade, tyvärr! Tryck ENTER för att avsluta spelet.");
            Console.ReadLine();
            Environment.Exit(0);    // Avsluta programmet vid förlust.
        }
    }
}