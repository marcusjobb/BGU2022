using System;
using System.Text;

string[] redDwarf =
{
    "It's cold outside, no kind of atmosphere",
    "I'm all alone, more or less",
    "let me fly far away from here",
    "Fun, Fun, Fun,",
    "In the sun, sun sun",
};

// Hämta sökvägen till "Mina dokument", alternativt "Mitt skrivbord"
string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
string documentSave = Path.Combine(docs, "RedDwarf.txt");

// Skapa en fil med namnet "RedDwarf.txt" i "Mina dokument" och skriv in arrayen i den
File.WriteAllLines(documentSave, redDwarf);

// Hämta en lista på alla text filer i "Mina dokument"
string[] files = Directory.GetFiles(docs, "*.txt");
// Loopa igenom listan av filer och skriv ut namnen
Console.WriteLine("Text filer i " + docs);
foreach(var file in files)
{
    // GetExtension hämtar filändelsen från filnamnet
    // GetFileNameWithoutExtension hämtar filnamnet utan filändelsen
    // GetFileName hämtar filnamnet inklusive filändelsen
    FileInfo info = new FileInfo(file);
    Console.WriteLine(Path.GetExtension(file) + "\t" + Path.GetFileNameWithoutExtension(file) + "\t" + info.Length + " bytes" + "\t" + info.CreationTime);
}

Environment.Exit(0);

string poem = File.ReadAllText("poem.txt");
Console.WriteLine(poem);
Console.WriteLine("-----------------------------------------------------");
string[] poemArray = File.ReadAllLines("poem.txt");
bool red = false;

foreach(var line in poemArray)
{
    // Om red är true skriv med röd färg
    // annars skriv med grön färg
    if(red)
        Console.ForegroundColor = ConsoleColor.Red;
    else
        Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine(line);

    // Om red är true gör den false
    // Om red är false gör den true
    red = !red;
}

Console.ResetColor();