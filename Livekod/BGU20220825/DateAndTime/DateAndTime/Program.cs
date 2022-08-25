// ----------------------------------------------------------
// DateTime är en inbyggd klass för hantering av tid
// ----------------------------------------------------------
Console.WriteLine(DateTime.Now); // Visar tid och datum nu


// ----------------------------------------------------------
// Skriver ut året
// ----------------------------------------------------------
Console.WriteLine(DateTime.Now.Year);

// ----------------------------------------------------------
// Standardvärde är 0001-01-01 00:00:00 (år 1, dag 1 midnatt)
// ----------------------------------------------------------
DateTime datum = new DateTime(1990, 12, 12);

// ----------------------------------------------------------
// .ToString() kan användas för att anpassa hur datumet
// skrivs ut
// ----------------------------------------------------------
Console.WriteLine(datum);
Console.WriteLine(datum.ToString("f"));

// ----------------------------------------------------------
// Man kan fylla på med dagar, månader, år mm
// ----------------------------------------------------------
datum = datum.AddDays(-14); // Lägger till -14 dagar (alltså drar ifrån 2 veckor)
Console.WriteLine(datum.ToString("f"));

// ----------------------------------------------------------
// Vi kan räkna antal dagar mellan två datum
// ----------------------------------------------------------
// Vi skapar ett juldatum för 2022
DateTime christmas = new DateTime(2022, 12, 24);

// (christmas - DateTime.Now) räknar dagar mellan de två datum
// och skapar automatiskt ett TimeSpan objekt
// TimeSpan kan alltid tala om för oss hur många dagar det skilljer
// med metoden .TotalDays
double days = (christmas - DateTime.Now).TotalDays;

// För att veta antal år mellan två datum, dividera TotalDays med 365.242199
Console.WriteLine(days);

// ----------------------------------------------------------
// Exempel på källhänvisning
// ----------------------------------------------------------
// Källa: https://www.tutorialsteacher.com/articles/get-difference-between-two-dates-in-csharp
