namespace EnkelVersion;

using System;
public class GissaTal
{
    /// <summary>
    /// Starta spelet
    /// </summary>
    public void Start()
    {
        while(true)
        {// Gissa ett tal mellan 1 och 100

            Random random = new Random();
            int number = random.Next(1, 101);

            int guesses = 0;
            Console.Clear();
            Console.WriteLine("Ett UFO är på väg att landa över din stad.");
            Console.WriteLine("Ditt jobb är att skjuta upp en missil som spränger");
            Console.WriteLine("UFOt, så att den hemliga organisationen S.T.E.A.L kan");
            Console.WriteLine("Stjäla deras information");
            Console.WriteLine("Riktningen på missilen anges i en skala från 1 - 100");
            Console.WriteLine("Din assistent kommer att hjälpa dig om du missar");
            Console.WriteLine();
            
            while(guesses < 10)
            {
                var guess = AskForANumber();
                guesses++;
                if(guess == number)
                {
                    Console.WriteLine("Rätt gissat!");
                    break;
                }
                else if(guess < number)
                {
                    Console.WriteLine("För lågt! Sikta högre!");
                }
                else
                {
                    Console.WriteLine("För högt! Sikta lägre!");
                }
            }
            
            if(guesses >= 10)
            {
                Console.WriteLine("Du missade och UFOt har nu kidnappat alla");
            }
            else
            {
                Console.WriteLine("Du klarade det!");
                Console.WriteLine($"Det tog dig {guesses} försök");
            }

            Console.WriteLine();
            Console.WriteLine("Radarn rapporterar att ett nytt UFO är på väg");
            Console.Write("Vill du...[F]örsöka igen eller ger du upp? ");
            var retry = Console.ReadLine().ToUpper();
            if(!retry.StartsWith("F")) break;
        }
    }

    private static int AskForANumber()
    {
        int guess = 0;
        Console.WriteLine("Ange koordinater (1-100)");
        while(true)
        {
            string input = Console.ReadLine();
            if(int.TryParse(input, out guess))
                return guess;
            Console.WriteLine("Kapten! Du måste skriva tal, inte text!");
        }
    }
}