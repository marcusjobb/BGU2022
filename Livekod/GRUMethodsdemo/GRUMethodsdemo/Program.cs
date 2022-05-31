Console.WriteLine("En triangels area");

//Console.WriteLine("Skriv en siffra");
//int number = int.Parse(Console.ReadLine()); // Inte bra, den kan krascha

// Deklarera variabeln vi ska använda
double size = GetMeasurements("Ange mått för triangel");
double area = size * size * Math.Sqrt(3) / 4;
PrintArea("Triangelns", area); // Math.Sqrt tar kvadratroten ur värdet

// Deklarera variabeln vi ska använda
double side = GetMeasurements("Ange mått för fyrkant");
area = side * side;
PrintArea("Fyrkantens", area);

void PrintArea(string name, double area)
{
    Console.WriteLine(name + " area är: " + area + ".");
}

/// <summary>
/// Metoden ställer en fråga, och omvandlar svaret till en double.
/// Därefter returnerar den värdet. Om felaktigt värde matas in
/// kommer den att fråga igen.
/// </summary>
/// <params name="message">Meddelande till användaren</params>
/// <returns>En double med värdet som skrevs in</returns>
double GetMeasurements(string message)
{
    double size = 0;
    // While kommer att upprepa frågan tills den får ett giltigt värde
    while(size <= 0)
    {
        // Fråga användare efter värdet
        Console.Write(message + " : ");
        string input = Console.ReadLine();

        // Tryparse kontrollerar att värdet är nummerisk, om den inte är det
        // kommer if-satsen att säga till att det är felaktigt
        // TryParse returnerar en bool, true om det gick bra, annars false
        // men ! framför gör att true blir false och false blir true
        // därmed körs if-satsen bara om värdet inte är nummerisk
        // Om värdet är nummerisk hamnar värdet i variabeln size
        bool IsNumeric = double.TryParse(input, out size);
        if(IsNumeric == false)
        {
            // värdet är inte nummerisk
            Console.WriteLine("Felaktig inmatning!!!");
        }
    }
    return size;
}