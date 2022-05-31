/*
        Fråga namn
    .-----------------.
    |   Start         |
    `-----------------´
             |
    +-----------------+
    | Fråga om namn   |
    +-----------------+
             |
    +-----------------+
    | Skriv Hej {Namn}|
    +-----------------+
             |
    .-----------------.
    |   End           |
    `-----------------´

Pseudokod:
Fråga om användarens namn
skriv "Hej {Namn}"
*/

// Deklarerar
string namn;
Console.WriteLine("Hej! Vad heter du?");
// Bearbetar
namn = Console.ReadLine();
// Presenterar resutatet
Console.WriteLine("Hej " + namn);
