// Syfte: användarens ålder omvandlas till hundår

// deklarera / definiera
int dogYear = 0;
int humanYear = 0;

// Hämta data
Console.WriteLine("Ange hundår");
string age = Console.ReadLine();
dogYear = int.Parse(age);

// kontrollera 

// beräkna
humanYear = dogYear * 7;

// presentera
Console.WriteLine($"En hund som är {dogYear} år är {humanYear} år i människoålder");