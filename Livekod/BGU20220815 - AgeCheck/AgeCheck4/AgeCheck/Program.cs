// deklarerar variabler
int age = 0;
bool manualGear = true;
bool handicap = false;

// Skriv ut frågan
Console.WriteLine("Hur gammal är du?");
// Läs in svaret till variabeln input som är en sträng
string input = Console.ReadLine(); // ger alltid en sträng tillbaka
// Omvandla input till ett heltal (int)
age = int.Parse(input);

if (age >= 95)
{
    Console.WriteLine("Ta en taxi");
}
else
{
    Console.WriteLine("Du kan köra: ");
    if (age > 5) Console.WriteLine("* Cykel");
    if (age >= 15) Console.WriteLine("* Moped");
    if (age >= 18)
    {
        Console.WriteLine("Är du handikappad? (J/N)");
        input = Console.ReadLine().ToUpper();
        if (input[0] == 'J') handicap = true;
        if (input[0] == 'N') handicap = false;

        if (handicap == true)
            manualGear = false;
        else
        {
            Console.WriteLine("Har du körkort för manuell växellåda?(J/N)");
            input = Console.ReadLine().ToUpper();
            if (input[0] == 'J') manualGear = true;
            if (input[0] == 'N') manualGear = false;
        }

        if (manualGear == true)
            Console.WriteLine("* Bil med manuell växellåda");
        else
            Console.WriteLine("* Bil med automatisk växellåda");
    }
    if (age >= 21) Console.WriteLine("* Tung mc");
}
