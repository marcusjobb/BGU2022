// ----------------------------------------------------------------------
// Som standard skapas all kod med samma mall
// ----------------------------------------------------------------------
// Steg                       | exempel
// ----------------------------------------------------------------------
// Deklarera variabler        | int x = 0;
// (vid behov gör input)      | Console.ReadLine()
// Kontrollera input          | if (input=="something) {...}
// Bearbeta informationen     | x = y-z^2;
// Presentera resultat        | Console.WriteLine()
// ----------------------------------------------------------------------


// ----------------------------------------------------------------------
// Exempel på hur man kan förenkla kod som upprepas genom
// att använda metoder
// ----------------------------------------------------------------------
// Fråga 1
// ----------------------------------------------------------------------
//Console.WriteLine("Hur gammal är du?");
//string input = Console.ReadLine() ?? "";
//int age = 0;
//// age = int.Parse(input); // Kraschar om input är text
//int.TryParse(input, out age); // Ger 0 om input är text
//Console.WriteLine($"Du är {age * 365.25} dagar gammal");
//// ----------------------------------------------------------------------

//// ----------------------------------------------------------------------
//// Fråga 2
//// ----------------------------------------------------------------------
//Console.WriteLine("Hur gammal är din hund?");
//input = Console.ReadLine() ?? "0";
//int dog = 0;
//int.TryParse(input, out dog);
//Console.WriteLine($"Din hund är {dog * 7} människoår");
//// ----------------------------------------------------------------------
int age = AskForANumber("Hur gammal är du?");
Console.WriteLine($"Du är {age * 365.25} dagar gammal");

int dog = AskForANumber("Hur gammal är din hund?");
Console.WriteLine($"Din hund är {dog * 7} människoår");

// ----------------------------------------------------------------------
// Lite if-satser för att kommentera vovvens ålder
// ----------------------------------------------------------------------
if (dog < 3) Console.WriteLine("Aaaaaw en liten valp!");
else if (dog > 20) Console.WriteLine("Oj Oj oj vilken gammal voffsing");
else if (dog > 10) Console.WriteLine("Oj det var en gammal vovve!");

// ----------------------------------------------------------------------
// metoden heter AskForANumber
// returnerar en int
// tar emot en text (sträng)
// ----------------------------------------------------------------------
int AskForANumber(string question)
{
    int response = 0; // variabeln som ska bli ett nummer från input
    Console.WriteLine(question);
    string input = Console.ReadLine();
    int.TryParse(input, out response); // omvandla text till siffror om det går

    return response; // skicka tillbaka resultatet
}