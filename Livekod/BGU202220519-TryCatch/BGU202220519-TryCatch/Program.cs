Console.WriteLine("Division");

int numA = AskUser("Ange första talet: ");
int numB = AskUser("Ange andra talet: ");

try
{
    int div = numA / numB;
    Console.WriteLine(div);
}
catch(Exception ex)
{
    Console.WriteLine("Något gick fel!");
    Log("numA:" + numA);
    Log("numB:" + numB);
    Log(ex.Message);
    Log(ex.Source);
    Log(ex.StackTrace);
}

// Metod för att kontrollera input
int AskUser(string message)
{
    while(true)
    {
        Console.Write(message);
        string input = Console.ReadLine();
        if(int.TryParse(input, out int value))
        {
            return value;
        }
    }
}

///<summary>
/// Skapar en loggfil med dagens datum
/// </summary>
void Log(string text)
{
    // År månad dag timme minut sekund
    string now = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

    // År månad dag
    string date = DateTime.Now.ToString("yyyy-MM-dd");

    string row = now + " " + text + Environment.NewLine;

    // File.WriteAllText = Skriv en fil med given text, om filen finns skrivs den över
    // File.AppendAllText = Skriv en fil med given text, om filen finns lägg till texten i slutet
    File.AppendAllText(date + ".txt", row);
}