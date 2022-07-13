namespace EnkelVersion;

using System;
public class GissaTal
{    
    /// <summary>
    /// Starta spelet
    /// </summary>
    public void Start()
    {
        // Flagga för att låta spelaren spela igen
        // som standard är den sant (true)
        bool KeepPlaying = true;

        // Spel-loopen 
        while(KeepPlaying)
        {
            ShowIntro();

            // Generera slumptal
            Random rand = new Random();
            int number = rand.Next(1, 101);

            //Antal gissningar
            int guesses = 0;

            // Loop för rundorna
            while(guesses < 10)
            {
                ShowStats(guesses);

                // Ta reda på vad användaren anger för tal
                var guess = GetGuess();
                // Öka antal gissningar för att hålla koll på hur många gånger man gissat
                guesses++;

                // Kontrollera svaret
                if(guess == number) // Win
                {
                    Console.WriteLine("Fullträff!");
                    Console.WriteLine("Jag ringer genast S.T.E.A.L. så att de kan dissekera UFOt!");
                    break;
                }
                else if(guess < number) // För stor
                {
                    Console.WriteLine("För lågt! Sikta högre!");
                }
                else // För litet
                {
                    Console.WriteLine("För högt! Sikta lägre!");
                }
            }

            // Kontrollera antal gissningar efter rundornas slut
            ShowResult(guesses);

            // Locka spelaren att spela igen
            var choice = AskToPlayAgain();

            // Utvärdera spelarens svar
            KeepPlaying = EvaluateChoice(choice);
        }
    }

    /// <summary>
    /// Utvärdera om spelaren tryckt F eller G
    /// </summary>
    /// <param name="choice">Tecknet som spelaren valt</param>
    /// <returns>Ett booleansk värde som antingen är sant eller falskt</returns>
    private static bool EvaluateChoice(char choice)
    {
        bool KeepPlaying;
        if(choice == 'F')
        {
            KeepPlaying = true;
        }
        else
        {
            KeepPlaying = false;
        }

        return KeepPlaying;
    }

    /// <summary>
    /// Lockar spelaren till att spela igen
    /// </summary>
    /// <returns>Returnerar ett Char med antingen F eller G</returns>
    private static char AskToPlayAgain()
    {
        Console.WriteLine();
        Console.WriteLine("Radarn rapporterar att ett nytt UFO är på väg");
        Console.Write("Vill du...[F]örsöka igen eller [G]er du upp? ");
        
        char choice = 'x';
        while(choice != 'F' && choice != 'G')
        {
            // Ta reda på spelarens val
            choice = Console.ReadKey().KeyChar.ToString().ToUpper()[0];
        }

        return choice;
    }

    /// <summary>
    /// Visar resultat av spelrundan
    /// </summary>
    /// <param name="guesses">Antal gissningar som användes</param>
    private static void ShowResult(int guesses)
    {
        if(guesses < 11)
        {
            // om rundorna är slut innan spelet kom till 10e försöket
            Console.WriteLine("Du klarade det!");
            Console.WriteLine($"Det tog dig {guesses} försök");
        }
        else
        {
            // Annars har man förlorat
            Console.WriteLine("Du missade och UFOt har nu kidnappat alla");
            Console.WriteLine("katter från staden....");
        }
    }

    /// <summary>
    /// Frågar användaren om en gissning och kollar så att användaren angett ett tal
    /// </summary>
    /// <returns>Talet som användaren angav</returns>
    private static int GetGuess()
    {
        Console.WriteLine("Ange ett tal mellan 1 - 100");
        int guess = 0;
        while(guess <= 0)
        {
            string input = Console.ReadLine();
            if(int.TryParse(input, out guess))
            {
                // TryParse sätter värdet på guess och då kan
                // vi lämna vår While loop med gott samvete
                break;
            }
            else
            {
                Console.WriteLine("Kapten! Du måste skriva tal, inte text!");
            }
        }

        return guess;
    }

    /// <summary>
    /// Visar var UFOt befinner sig (antal gissningar kvar) och frågar om ett tal
    /// </summary>
    /// <param name="guesses">Antal gissningar som använts hittils</param>
    private static void ShowStats(int guesses)
    {
        int ufo = (10 - guesses) * 100;
        Console.WriteLine($"UFOt befinner sig på {ufo} m över staden");
    }

    /// <summary>
    /// Visar intro till spelet
    /// </summary>
    private static void ShowIntro()
    {
        // Intro
        Console.Clear();
        Console.WriteLine("Ett UFO är på väg att landa över din stad.");
        Console.WriteLine("Ditt jobb är att skjuta upp en missil som spränger");
        Console.WriteLine("UFOt, så att den hemliga organisationen S.T.E.A.L kan");
        Console.WriteLine("Stjäla deras information");
        Console.WriteLine("Riktningen på missilen anges i en skala från 1 - 100");
        Console.WriteLine("Din assistent kommer att hjälpa dig om du missar");
        Console.WriteLine();
    }
}