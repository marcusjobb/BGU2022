namespace BGU_GissaTal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Helper
{
    public int HelperId { get; set; }
    public string Help { get; set; }
    public int Max { get; set; }
    public int Min { get; set; }
    public int GuessMax { get; set; }
    public int GuessMin { get; set; }

    private Random random = new Random();


    public Helper()
    {
        Help = "";
        HelperId = 0;
    }

    public Helper(int lowest, int highest)
    {
        GuessMax = highest;
        GuessMin = lowest;
        Max = highest;
        Min = lowest;
    }

    public void PrintHelp()
    {
        if(HelperId < 1) return;
        GetHelp();
        if(!string.IsNullOrEmpty(Help))
        {
            Console.WriteLine(Help);
        }
    }

    private void GetHelp()
    {
        string suggestion = "";
        int guess = 0;
        switch(HelperId)
        {
            case 1: // Mr Random
                guess = random.Next(GuessMin, GuessMax);
                suggestion = $"Jag skulle gissa på {guess}";
                break;
            case 2: // Mr Logic
                guess = Min + (GuessMax - GuessMin) / 2;
                suggestion = $"Min logiska gissning skulle vara {guess}";
                break;
            case 3: // Miss Visual
                suggestion = new string(' ', GuessMin) + ">";
                suggestion += new string('-', GuessMax) + "<";
                break;
        }
        Help = "Din assistent säger: " + suggestion;
    }

    public string GetName()
    {
        switch(HelperId)
        {
            case 1:
                return "Mr Random";
            case 2:
                return "Mr Logic";
            case 3:
                return "Miss Visual";
            default:
                return "Ingen aktiverad";
        }
    }

    internal void GuessedTooHigh(int guess)
    {
        if(guess < GuessMax)
        {
            GuessMax = guess;
        }
    }
    internal void GuessedTooLow(int guess)
    {
        if(guess > GuessMin)
        {
            GuessMin = guess;
        }
    }
}

