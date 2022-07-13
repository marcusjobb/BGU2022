# Feedback

Grymt spel!
Spännande med en drake som jagar en, en kommentar typ "Du öppnade fel dörr och draken flyttar sig ny närmare dig..." skulle nog gett mig panik :flushed:

Spelet är spännande!

Bra skriven kod och väldigt snyggt att du använde en engine class för att hantera spelgången. Det gör koden mer läsbar och mer lätthanterlig. Du verkar ha full koll på kodningen redan - jättebra!

Du använder get-metoder som read-only properties, bra val av användning av det! Alternativt hade du kunnat använda dig av properties 

```cs
	public int NumberofGuesses {get {return _numberOfGuesses;}}
```

Det här är riktigt classy! Bra gjort!
```cs
while (int.TryParse(userInput, out userGuess) == false)
{
    Console.WriteLine("Oj, nu fattade jag inte! Använd endast siffror.");
    Console.WriteLine("Vilken dörr vill du öppna?");
    userInput = Console.ReadLine();
}
```

Bra slut på spelet! Ingen diskussion om hur det gick :)
```cs
Console.WriteLine("Tyvärr, alla dörrar gick i baklås och draken slukade upp dig!");
```

Bra kommentarer och bra namngivning på variabler och metoder. 

**Du kommer att bli en grym kodare (om du inte är det redan)!**

