class Play
{ 
    static void Main(string[] args)
    {
        var game = new Numberguessinggame();
        game.Run();
    }
    
}

class Numberguessinggame
{
    bool run = true;
    int maxTrys = 10;
    Random random = new Random();

    public void Run()
    {
        while (run)
        {
            int rnd = random.Next(1, 101);
            NewMethod10();
            int trys = 0;
            bool solved = false;
            while (!solved && trys < maxTrys)
            {
                trys++;
                int guess;
                bool numericGuess;
                do
                {
                    numericGuess = int.TryParse(Console.ReadLine(), out guess);
                    if (!numericGuess)
                    {
                        NewMethod9();
                    }
                } while (!numericGuess);

                if (guess > rnd)
                {
                    SayGuessLower(guess);
                }
                else if (guess < rnd)
                {
                    SayGuessHigher(guess);
                }
                else if (guess == rnd)
                {
                    solved = true;
                    SayYouWon(rnd, trys);
                }
            }
            if (!solved)
            {
                NewMethod2();
                NewMethod4();
            }

            NewMethod3();
            string rerun = Console.ReadLine().ToUpper();    

            if (!rerun.Equals("R"))
            {
                run = false;
            }
        }
        NewMethod2();
        NewMethod1();
        NewMethod();

    }

    //METODER
    private static void NewMethod10()
    {
        Console.WriteLine("You have 10 tires to guess the number im thinking of between 1 and 100 or i will take over your brain");
    }

    private static void NewMethod9()
    {
        Console.WriteLine("You idiot! I said guess a number between 1 and 100 and you type letters? HA HA HA that brain is going to be delicious");
    }

    private static void SayGuessLower(int guess)
    {
        Console.WriteLine(string.Format("HA! My number is lower than {0}\n you fool! guess again >>", guess));
    }

    private static void SayGuessHigher(int guess)
    {
        Console.WriteLine(string.Format("HIGHER HIGHER my number is higher than {0}\n guess again you tool >>", guess));
    }

    private static void SayYouWon(int rnd, int trys)
    {
        Console.WriteLine(string.Format("Darn it! how could you possibly know it was {0} your brain will be mine some other day!", rnd, trys));
    }

    private void NewMethod4()
    {
        Console.WriteLine(string.Format("You only have {0} trys. You failed, your brain is officially mine HA HA HA! \n", maxTrys));
    }

    private static void NewMethod3()
    {
        Console.WriteLine("If you want to play again and risk it all Press R + Enter to play again!");
    }

    private static void NewMethod2()
    {
        Console.Clear();
    }

    private static void NewMethod1()
    {
        Console.WriteLine("Thanks for playing see you next time!");
    }

    private static void NewMethod()
    {
        Console.ReadLine();
    }
}