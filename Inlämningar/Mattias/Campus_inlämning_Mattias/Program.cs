using System.Text;

//Inlämningsuppgift för Campus Mölndal av Mattias Magnemyr 2022-06-28
//Spelet jag gjort har ett "tema" där en prinsessa är fågnad av en drake och satt i ett rum.
//Spelarens uppgift är att lista ut vilket rum hon sitter fångad i innan draken hittar dig.
//Spelet finns i klassen saveThePrincess och man startar det genom att anropa metoden startGame()
//

saveThePrincess game = new saveThePrincess();
game.startgame();

Console.WriteLine("Tryck på valfri tangent för att avsluta.");
Console.ReadKey();

/// <summary>
/// en klass för spelet "saveThePrincess". Detta spel är ett gissa-ett-tal spel med ett visst tema. Den
/// använder klassen gameEngine för att dra ett slumptal och hålla koll på antal gissningar mm.
/// starta spelet genom att använda metoden startGame()
/// </summary>
public class saveThePrincess
{
    public void startgame()
    {

        gameEngine theGame = new gameEngine();
        theGame.startGame();

        Console.WriteLine("En prinsessa är fångad i ett slott med " + theGame.getMaxNumber() + " rum.");
        Console.WriteLine("Varje rum har ett nummer mellan " + theGame.getMinNumber() + " och " + theGame.getMaxNumber());
        Console.WriteLine("Ju längre bort rumen ligger, desto högre rumsnummer.");
        Console.WriteLine("Slottet vaktas av en farlig, eldsprutande drake. Den vet att du är här.");
        Console.WriteLine("Du hinner endast öppna " + theGame.getMaxNumberOfGuesses() + " dörrar innan draken hittar dig!");
        Console.WriteLine("Vilken dörr vill du öppna först?");

        int userGuess = 0;

        string resp = "";

        bool gameOver = false;
        bool gameComplete = false;

        while (gameOver == false && gameComplete==false)
        {
            string? userInput = Console.ReadLine();

            //om spelaren inte har matat in siffor utan text så kollar vi det här!
            //int.TryParse kollar om det verkligen går att konvertera det användaren matat in till en int
            //och om det går returnerar den true annars false. Det konverterade talet kommer att finnas i
            //out parametern userGuess.
            while (int.TryParse(userInput, out userGuess) == false)
            {
                Console.WriteLine("Oj, nu fattade jag inte! Använd endast siffror.");
                Console.WriteLine("Vilken dörr vill du öppna?");
                userInput = Console.ReadLine();
            }

            
            resp = theGame.addNewGuess(userGuess);

            if (resp == "correct")
            {
                Console.WriteLine("GRATTIS!!!! Du hittade prinsessan efter att ha öppnat " + theGame.getNumberOfGuesses() + " dörrar!");
                gameComplete = true;

            }

            else if (resp == "tooHigh")
            {
                Console.WriteLine("Du letar för långt bort! Prova lite närmare.");
                
            }

            else if (resp == "tooLow")
            {
                Console.WriteLine("Du letar för nära! Prova lite längre bort.");
            }

            if(gameComplete==false)
            {
                Console.Write("Du har nu öppnat " + theGame.getNumberOfGuesses() + " dörrar!\n");
            }

            if (theGame.getNumberOfGuesses() == theGame.getMaxNumberOfGuesses())
            {
                Console.WriteLine("Tyvärr, alla dörrar gick i baklås och draken slukade upp dig!");
               
                
                gameOver = true;
            }
        }
    }
}

/// <summary>
/// en klass för spelet gissa-ett-tal utan något "tema". Här dras ett slumptal. Vi håller koll på hur många gissningar
/// som gjorts, om man gissar rätt eller för högt eller för lågt
/// </summary>
public class gameEngine
{
    #region privateMembers
    
    private int _randomNumber;
    private int _maxNumberOfGuesses;
    private int _minNumber;
    private int _maxNumber;
    private int _numberOfGuesses;
    private bool _isGameComplete = false;

    #endregion

    #region pulbicMethods
    public int getMaxNumberOfGuesses()
    {
        return _maxNumberOfGuesses;
    }
    public int getMinNumber()
    {
        return _minNumber;
    }
    public int getMaxNumber()
    {
        return _maxNumber;
    }
    public int getNumberOfGuesses()
    {
        return _numberOfGuesses;
    }

    public bool isGameOver()
    {
        if(_numberOfGuesses==_maxNumberOfGuesses)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool isGameComplete()
    {
        return _isGameComplete;
    }

    public void startGame()
    {
        _minNumber = 1;
        _maxNumber = 100;
        _maxNumberOfGuesses = 10;
        _numberOfGuesses = 0;
        Random rnd = new Random();
        _randomNumber = rnd.Next(_minNumber, _maxNumber);

    }
    public string addNewGuess(int newGuess)
    {
        string ret = "";
        _numberOfGuesses++;

        if (_numberOfGuesses > _maxNumberOfGuesses)
        {
            ret = "tooManyGuesses";
        }


        else if (newGuess > _randomNumber)
        {
            ret = "tooHigh";
        }
        else if (newGuess < _randomNumber)
        {
            ret = "tooLow";
        }
        else
        {
            ret = "correct";
            _isGameComplete = true;
        }

        

        return ret;
    }

    #endregion

}




