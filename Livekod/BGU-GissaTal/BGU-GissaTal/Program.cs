using BGU_GissaTal;
int gamesPlayed = 0;
const int lowest = 1;
const int highest = 100;
const int maxGuess = 10;
Random random = new Random();
Helper helper = new Helper(lowest, highest);
Input input = new Input();
Story story = new Story();
while(true)
{
    int choice = input.MainMenu(helper.GetName());
    if(choice == -1) break;
    if(choice == -2)
    {
        helper.HelperId = input.HelperMenu();
        continue;
    }
    story.SetStory(choice);
    
    gamesPlayed++;

    Console.Clear();
    string intro = string.Format(story.Intro, lowest, highest, maxGuess);
    Console.WriteLine(intro);

    int roundsCounter = 0;
    int secret = random.Next(1, 101);
    while (roundsCounter<10)
    {
        string guessString = string.Format(story.Guess, lowest, highest);
        Console.WriteLine(guessString);
        Console.WriteLine();
        helper.PrintHelp();
        roundsCounter++;
        int guess = input.GuessANumber(lowest,highest);
        if(guess < secret)
        {
            Console.WriteLine(story.TooLow);
            helper.GuessedTooLow(guess);
        }
        else if(guess > secret)
        {
            Console.WriteLine(story.TooHigh);
            helper.GuessedTooHigh(guess);
        }
        else
        {
            Console.WriteLine(story.WinGame);
            break;
        }
    }
    if(roundsCounter >= 10)
        Console.WriteLine(story.LostGame);

    if(input.PlayAgain() == 0) break; 
}

