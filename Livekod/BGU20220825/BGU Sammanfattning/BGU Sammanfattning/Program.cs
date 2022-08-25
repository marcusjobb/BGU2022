Console.WriteLine("Hello, BGU!");

int number = 0;

while (number == 0) // Upprepa tills number har ett annat värde än noll
{
    Console.WriteLine("Ange ett tal mellan 1 och 10");
    string input = Console.ReadLine();
    if (!int.TryParse(input, out number)) 
    {
        // TryParse returnerar true om den kan omvandla 
        // och false om den inte kan
        // Alltså kontrollerar om den inte kan
        // ! = sätt det booleanska värdet till motsatsen
        // Om den kan omvandla hoppa över if-satsen
        // Om den inte kan omvandla kör Console.WriteLine
        Console.WriteLine("Ange bara tal, inga andra dumheter!");
    }
}


if (number > 5)
    Console.WriteLine("Större än 5");
else if (number < 5)
    Console.WriteLine("Mindre än 5");
else
    Console.WriteLine("Fem");