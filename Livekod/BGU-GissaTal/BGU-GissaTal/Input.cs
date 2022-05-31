namespace BGU_GissaTal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Input
{
    public int MainMenu(string currentHelpter)
    {
        Console.Clear();
        Console.WriteLine("* Gissa ett tal *");
        Console.WriteLine("Vilken story vill du spela?");
        Console.WriteLine("1 - Ufo");
        Console.WriteLine("H - Välj hjälpare ["+currentHelpter+"]");
        Console.WriteLine("X - Avsluta spelet");
        char choice = AskforAny("1HX");
        switch(choice)
        {
            case 'x':
            case 'X': return -1;
            case 'H':
            case 'h': return -2;
            default: return int.Parse(choice.ToString());
        }
    }

    public int PlayAgain()
    {
        Console.WriteLine();
        Console.WriteLine("Vill du spela igen? (j/n)");
        char choice = AskforAny("jn");
        if(choice == 'j' || choice == 'J')
            return 1;
        else
            return 0;
    }

    private char AskforAny(string chars)
    {
        while(true)
        {
            char choice = Console.ReadKey().KeyChar;
            if(chars.Contains(choice, StringComparison.InvariantCultureIgnoreCase))
            {
               return choice;
            }
        }
    }

    public int StoryMenu()
    {
        Console.Clear();
        Console.WriteLine("* Gissa ett tal *");
        Console.WriteLine("Vilken story vill du spela?");
        Console.WriteLine("1 - Ufo");
        Console.WriteLine("2 - Välj hjälpare");
        Console.WriteLine("0 - Avsluta spelet");
        return AskForNumber(0, 2);
    }

    public int HelperMenu()
    {
        Console.Clear();
        Console.WriteLine("Välj en hjälpare");
        Console.WriteLine("1 - Mr Random");
        Console.WriteLine("2 - Mr Logic");
        Console.WriteLine("3 - Miss Visual");
        Console.WriteLine("0 - Ingen hjälpare");
        return AskForNumber(0, 3);
    }
    
    public int AskForNumber(int min, int max)
    {
        Console.WriteLine();
        Console.WriteLine($"Ange ett tal mellan {min} och {max}");
        return AskForNumberEx(min, max);
    }

    public int GuessANumber(int min, int max)
    {
        Console.WriteLine();
        Console.WriteLine($"Gissa ett tal mellan {min} och {max}");
        return AskForNumberEx(min, max);
    }

    int AskForNumberEx(int min, int max)
    {
        while(true)
        {
            string input = Console.ReadLine();
            if(int.TryParse(input, out int value))
            {
                if(value >= min && value <= max) return value;
            }
        }
    }

}
