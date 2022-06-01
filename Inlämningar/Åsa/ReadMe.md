# Programmet gissningslek

Bra spel! Helt underbart med humoristiska kommentarer! :joy:
Jättekul med specifika kommentarer som talar om hur bra man klarade sig, baserat på antal försök. Det gillade jag verkligen, stort plus där! Riktigt snyggt sätt att kommunicera med din användare.

Underbar metod!
```cs
internal void HurBraVarGissnigen(int antalFörsök) //Metod ger olika grattissvar. Valiabeln antalFörsök är gissningens nr.
{ 
string svar;
    switch (antalFörsök)
    {
            case 1: svar = "Wow, duklarade det på första försöket. Bravo!!!"; break;
            case 2: svar = "Träff!! På andra försöket, det var bra!";   break;
            case 9: svar = "Det var inte mycket till marginal, bravo!"; break;
            case 10: svar = "Det var på håret, rätt på sista försöket!";  break;
            default: svar = "Rätt på försök nummer " + counter; break;
    }
    Console.WriteLine(svar);
}
```

Väldigt snyggt skriven kod, bra namngivning på dina metoder och variabler. Jättebra att du även hade med [[Pseudokod]]


