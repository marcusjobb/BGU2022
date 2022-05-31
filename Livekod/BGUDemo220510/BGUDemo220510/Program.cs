
for(int y = 2; y < 20; y++)
{
    for(int x = 2; x < y; x++)
    {
        //if(x % 2 == 0) continue;
        Console.SetCursorPosition(x, y);
        Console.Write("*");
    }
}
Console.WriteLine();
Console.WriteLine();
Environment.Exit(0);

for(int count = 0; count < 20; count++)
{
    if(count % 2 == 0) continue;
    Console.WriteLine(count);
}

Environment.Exit(0);

for(int count = 0; count < 20; count++)
{
    if(count == 8) break;
    Console.WriteLine(count);
}

Environment.Exit(0);
string[] todo = new string[]
{
    // antal : 4
    //    0             1             2             3
    "Handla mjölk", "Mata katten", "Träna", "Kolla på en skräckfilm"
};

//for (int row=0; row<todo.Length; row++)
//{
//    Console.WriteLine($"{row} - {todo[row]}");
//}

foreach(string todoItem in todo)
{
    Console.WriteLine(todoItem);
}

Environment.Exit(0);

double savings = 100;
double savingsTotal = 0;
int years = 10;

for(int counter = 0; counter < years; counter++)
{
    savingsTotal += savings;
    savings *= 1.05;
    Console.WriteLine($"{counter} : {Math.Round(savings, 2)}");
}
Console.WriteLine(Math.Round(savingsTotal, 2));

Environment.Exit(0);

string myName = "Marcus";

while(myName == "")
{
    Console.WriteLine("Ange ditt namn");
    myName = Console.ReadLine();
}
Console.WriteLine($"Hej {myName}");


Environment.Exit(0);

int number = 1;
string numInput = "";

do
{
    Console.WriteLine("Ange ett tal mellan 1 och 10");
    numInput = Console.ReadLine();

    if(!int.TryParse(numInput, out number))
    {
        Console.WriteLine("Ange en siffra ditt pucko!");
    }
}
while(number < 1 || number > 10);

Console.WriteLine("Du angav:" + number);

Environment.Exit(0);

int month = 10;
string holliday = "";

switch(month)
{
    case 1: holliday = "Nyår"; break;
    case 2: holliday = "Alla hjärtans"; break;
    case 3: holliday = "Vårdagjämning"; break;
    case 4: holliday = "Påsk"; break;
    case 5: holliday = "Valborg"; break;
    case 6: holliday = "Midsommar"; break;
    case 7: holliday = "Semester!!!"; break;
    case 8: holliday = "Kräftpremiär"; break;
    case 9: holliday = "Surströmmingspremiär"; break;
    case 10: holliday = "Halloween"; break;
    case 11: holliday = "Black friday"; break;
    case 12: holliday = "Xmas!"; break;
    default: holliday = "Hittade ingen högtid"; break;
}

Environment.Exit(0);

double skjorta = 354.25;
double vårRabatt = .15;
double helgRabatt = 50;

if(helgRabatt > 0)
{
    skjorta = skjorta - helgRabatt;
}
else if(vårRabatt > 0)
{
    skjorta = skjorta * (1 - vårRabatt);
}


Console.WriteLine($"Pris på skjortan är {skjorta}");


Environment.Exit(0);

Console.WriteLine("Regnar det idag? (ja/nej)");
string input = Console.ReadLine();
bool rain = input.StartsWith('j'); // Kollar om första bokstaven är j

// '' <--- för character, alltså en bokstav i taget
// "" <--- för text, alltså string

if(rain)
{
    Console.WriteLine("Bäst att du använder ett paraply!");
}
else
{
    Console.WriteLine("Vad bra!");
}

Console.WriteLine("Klar!");
