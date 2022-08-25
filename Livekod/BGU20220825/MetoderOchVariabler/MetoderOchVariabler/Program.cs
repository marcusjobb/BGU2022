
// Skapar en sträng som ska skrivas ut
string minText = "Hejsan hoppsan";
Skriv(minText);
Console.WriteLine(minText);
Elak(ref minText);
Console.WriteLine(minText);

// void = returnerar ingenting
// variabeln text får en kopia av "minText" som skickats in (byVal = by value)
void Skriv(string text)
{
    text += "!!!"; // Lägger till tre utropstecken på texten
    Console.WriteLine(text); // skriver ut texten
}

void Elak (ref string text) // Kör genom referens
{
    text += "-";
    Console.WriteLine(text); // skriver ut texten
}

// Deklarera variabler        | int x = 0;
// (vid behov gör input)      | Console.ReadLine()
// Kontrollera input          | if (input=="something) {...}
// Bearbeta informationen     | x = 256;
// Presentera resultat        | Console.WriteLine()