namespace gamegeneratortwo
{
    internal class Game
    {
        /*

        private void Responses(string? answer) 
        {
          
            switch (answer) //alternative to many if statements BroCode - youtube, Switch statements. 
            {
                case "yes:":
                    Console.WriteLine("Get ready to play again!");
                    break;  
                case "no":
                    Console.WriteLine("Thanks for playing!");
                    break;
                default:
                    break;
                    Console.WriteLine("Thanks for playing");
            }

        }*/

        private void TriesCounter(int tries)
        {
            Console.WriteLine("you have tried " + tries + " times");
        }

        private void SpelIntro()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Roses are red and voilets are blue, here is a game made just for you.");
            Console.WriteLine("Guess the correct number and you will win, ");
            Console.WriteLine("Guess wrong ten times, you won't get a new chance to begin, ");
            Console.WriteLine("because you failed. ");
        }

        public void Start() // Hjälp från Marcus Medina 
        {
            SpelIntro();//hjälp från Marcus 

            Random Random = new Random(); //in charge of generating random numbers 
            bool KeepPlaying = true; //set to true, alltså är det felgissning.
            int max = 100;// en lek mellan 1 - 100
            int min = 1;
            int radomizedNumber = Random.Next(min, max + 1);//plus ett pga annars blir det 99
            string responses;//den skippar 
            int tries = 0; //hur många försök user har på sig, räknar även med felgissningar. pga jag vill det. 

            while (KeepPlaying) // keep playing
            {
                Console.WriteLine("\n ");
                Console.WriteLine("Guess a number between 1 and 100: ");

                string guess = Console.ReadLine();
                int GuessAsInt = 0;
                bool validInt = Int32.TryParse(guess, out GuessAsInt);//BroCode youtube - tryparse
                tries++;

                if (tries == 11)//10 tires 
                {
                    Console.WriteLine("Hah! You thought you got another chance! Tricksies! You have lost the game ;) ");
                    break;
                }

                if (validInt)//check if int
                {
                    Console.WriteLine("You guessed " + GuessAsInt);
                }
                else//if string etc break
                {
                    Console.WriteLine("Incorrect Value, please try again.");
                    continue;//jens(bror) hjälpte mig
                }

                if (GuessAsInt > max)//check if guess is higher than max
                {
                    Console.WriteLine(GuessAsInt + " is higher than maximum value(100)");
                    TriesCounter(tries);
                    continue;
                }

                if (GuessAsInt < min) //check if lower
                {
                    Console.WriteLine(GuessAsInt + " is lower than minimum value(0)");
                    TriesCounter(tries);
                    continue;
                }

                //reset GuessAsInt variable
                if (GuessAsInt < radomizedNumber)
                {
                    Console.WriteLine(GuessAsInt + " is too low");
                    TriesCounter(tries);
                    continue;
                }

                else if (GuessAsInt > radomizedNumber)//exception handling GiraffeAcademy youtube, tutorial 24
                {
                    Console.WriteLine(GuessAsInt + " is too high");
                    Console.WriteLine("you have tried " + tries + " times");
                    continue;
                }

                if (GuessAsInt == radomizedNumber)
                {
                    Console.WriteLine("YOU WIN");
                }
                Console.WriteLine("You've won with " + tries + " tries");
                Console.WriteLine("Do you wish to play again? Y/N");

                responses = Console.ReadLine();
                responses = responses.ToUpper();
                Console.WriteLine(responses);
                if(responses = ("Y"))//                              
                {
                    radomizedNumber = Random.Next(min, max + 1);
                    tries = 0;
                    continue;
                }
                else
                {
                    KeepPlaying = false;
                    break;
                }
            }
        }
    }
}

  