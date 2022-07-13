# Feedback

Coolt spel!
Som om en ond Professor Xavier som försöker ta över hjärnan!

Roliga elaka kommentarer som skrämmer och stressar medan man försöker gissa. Hur coolt som helst.

Ett tips. ***String.format*** är riktig bra att använda, men den behövs inte på Console.WriteLine() 
```cs
Console.WriteLine("HA! My number is lower than {0}\n you fool! guess again >>", guess);
```
men misströsta inte, den kommer du att ha nytta av i framtiden när du ska sätta ihop kopplingsinställningar till databasen :wink:


```cs
Console.WriteLine(string.Format("HIGHER HIGHER my number is higher than {0}\n guess again you tool >>", guess));
```

Bra kommentarer och bra namngivning på variabler.
Kul att du skapade metoder för alla outputs, om de fått namn som antytt vad de gör skulle koden varit hur lätt att läsa som helst.

Kolla här
```cs
if (guess > rnd)
{
    NewMethod8(guess);
}
else if (guess < rnd)
{
    NewMethod7(guess);
}
else if (guess == rnd)
{
    solved = true;
    NewMethod6(rnd, trys);
}
```
och jämför med

```cs
if (guess > rnd)
{
    SayGuessLower(guess);
}
else if (guess < rnd)
{
    SayGuessHigher(guess);
}
else if (guess == rnd)
{
    solved = true;
    SayYouWon(rnd, trys);
}
```

Inget fel på din kod dock, längre fram i utbildningen ska vi kolla på regler för namngivning och sånt... inget att oroa sig för nu.