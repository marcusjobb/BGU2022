// ----------------------------------------------------------
{
    // ----------------------------------------------------------------------
    // Detta är ett skräckexempel på hur en loop fungerar!
    // gör aldrig så!
    // initiera variabeln counter
    // ----------------------------------------------------------------------
    int counter = 0;

// Börja upprepa
repeat:

    // om counter är mindre än 10 öka med ett och fortsätt
    if (counter < 10)
    {
        counter++;
        Console.WriteLine(counter);
    }
    else
    {
        // annars avsluta loopen
        goto end;
    }
    goto repeat; // No no no!!! Använd aldrig goto!!!
end:
    Console.WriteLine("Done");
}
// ----------------------------------------------------------

// ----------------------------------------------------------
// For-loop
// ----------------------------------------------------------
{
    //for (

    //    int counter = 0; // Deklarera variabel
    //    counter < 10; // Villkor
    //    counter++ // hur ska räknaren öka eller minska

    //    )

    // counter++  --> counter + 1
    // counter+=3 --> counter + 3
    // counter-=2 --> counter - 2
    // counter*=2 --> counter * 2
    // counter/=2 --> counter / 2

    for (int counter = 0; counter <= 10; counter += 2)
    {
        Console.WriteLine(counter);
    }
    Console.WriteLine("Done");
}
// ----------------------------------------------------------

// ----------------------------------------------------------
// While och do-while loopar
//
// While kör inte om villkoret uppfylls från början
// Do While kör oavsett vilket minst en gång
// ----------------------------------------------------------
{
    // Vi vet inte hur många gånger loopen ska köras
    // == --> Lika med
    // != --> inte lika med
    string password = "hello";
    string? input = "hello";

    // ----------------------------------------------------------
    // kan hoppa över om villkoret uppfylls från början
    // ----------------------------------------------------------

    while (password != input) // Loopa så länge password inte är lika med input
    {
        Console.WriteLine("Enter password");
        input = Console.ReadLine();
    }

    // ----------------------------------------------------------
    // Denna kör loopen minst en gång då villkoret kontrolleras i slutet av loopen
    // ----------------------------------------------------------
    do
    {
        Console.WriteLine("Enter password");
        input = Console.ReadLine();
    } while (password != input);
}


// En array är en lista av data
// Arrayer börjar alltid med position noll
string[] names = { "Batman", "Robin", "Batgirl", "Catwoman", "White Canary", "Oracle" };
{
    // ----------------------------------------------------------
    // Loop som skriver ut 3 namn bara
    // Använd hellre en loop än att skriva ut alla för hand
    // Console.WriteLine(names[0]); // Batman
    // Console.WriteLine(names[1]); // Robin
    // Console.WriteLine(names[2]); // Batgirl
    // Console.WriteLine(names[3]); // Catwoman
    // Console.WriteLine(names[4]); // White Canary
    // Console.WriteLine(names[5]); // Oracle
    // ----------------------------------------------------------
    for (int person = 0; person < 3; person++)
    {
        Console.WriteLine(names[person]);
    }
}
{
    // ----------------------------------------------------------
    // Foreach fungerar enbart med listor
    // man kan inte ändra i variabeln 
    // ----------------------------------------------------------
    foreach (string person in names)
    // för varje "sak" i listan "names" lägg värdet i variabeln person 
    {
        // Värdet i person variabeln ändras för varje runda i loopen
        Console.WriteLine(person);
    }
}

