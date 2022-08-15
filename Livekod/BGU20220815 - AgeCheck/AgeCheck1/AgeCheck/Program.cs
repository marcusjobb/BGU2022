// deklarerar variabler
int age = 0;

// Skriv ut frågan
Console.WriteLine("Hur gammal är du?");
// Läs in svaret till variabeln input som är en sträng
string input = Console.ReadLine(); // ger alltid en sträng tillbaka
// Omvandla input till ett heltal (int)
age = int.Parse(input);

if (age < 95)
{
    Console.WriteLine("Du kan köra: ");
    if (age > 5) Console.WriteLine("* Cykel");
    if (age >= 15) Console.WriteLine("* Moped");
    if (age >= 18) Console.WriteLine("* Bil");
    if (age >= 21) Console.WriteLine("* Tung mc");
}
else
{
    Console.WriteLine("Ta en taxi");
}
