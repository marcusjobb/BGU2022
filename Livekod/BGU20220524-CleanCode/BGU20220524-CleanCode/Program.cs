// See https://aka.ms/new-console-template for more information

// Deklarerar variabeln "number" och ger den värdet 10
int number = 10;

// Skickar värdet i "number" till metoden DoubleUp och fångar upp
// resultatet i variabeln doubleNumber när den returnerar resultatet
int doubleNumber = DoubleUp(number);

// Skriver ut variablernas värde
Console.WriteLine("Number: " + number);
Console.WriteLine("Double: " + doubleNumber);

// Tar emot ett int värde och lägger det i variabeln "x"
int DoubleUp(int x)
{
    // returnerar variabeln "x" multiplicerat med 2
    return x * 2;
}

