// Deklarera bankkonto
Account account = new Account();
int nummer = 24;

// Meny
Console.WriteLine("Bank");
Console.WriteLine("1 - Insättning");
Console.WriteLine("2 - Uttag");
Console.WriteLine("3 - Se saldo");

string input = Console.ReadLine();
if (input == "1")
{
    Console.WriteLine("Insättning: Hur mycket pengar vill du sätta in.");
    string cash = Console.ReadLine();

    int amount = int.Parse(cash);
    //account.Balance = account.Balance + amount;
    //account.Balance += amount; // Förenklat
    account.Insättning(amount);

    Console.WriteLine("Cash : " + account.Balance);
}
else if (input == "2")
{
    Console.WriteLine("Uttag: Hur mycket pengar vill du ta ut.");
    string cash = Console.ReadLine();

    int amount = int.Parse(cash);
    //account.Balance = account.Balance - amount;
    //account.Balance -= amount; // Förenklat

    account.Uttag(amount);
    Console.WriteLine("Cash : " + account.Balance);

    //Hacker
    //account.Balance = 9999;
    Console.WriteLine("Cash : " + account.Balance);
}
else if (input == "3")
{
    Console.WriteLine("Cash : " + account.Balance);
}
else
{
    Console.WriteLine("Felaktig inmatning");
}

class Account
{
    // Balance är en egenskap av Account
    // Private set gör det skrivskyddat för omgivningen
    public int Balance { get; private set; } = 1000; // Standard värde

    public int Insättning(int amount)
    {
        if (amount < 0) amount = 0;
        Balance = Balance + amount;
        return Balance;
    }

    public int Uttag(int amount)
    {
        if (amount < 0) amount = 0;
        if (Balance >= amount)
            Balance = Balance - amount;
        return Balance;
    }
}