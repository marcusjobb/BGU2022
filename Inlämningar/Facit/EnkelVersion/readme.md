# Gissa ett tal

## Spelhandling
Ett UFO är på väg att landa över din stad.

Ditt jobb är att skjuta upp en missil som spränger UFOt, så att den hemliga organisationen S.T.E.A.L kan stjäla deras information

Riktningen på missilen anges i en skala från 1 - 100

Din assistent kommer att hjälpa dig om du missar.

# Om koden
Koden innehåller två loopar.

Variablerna **number**, **guesses** och **guess** är allt som krävs för att spelet ska fungera.

I början finns en evig loop
```cs 
while(true) {...} 
```
While(true) är ett enkelt sätt att skapa en evig loop, enda sättet att komma ut ur den är att använda ***break;*** 

Jag använder metoden ***AskForANumber();*** för att fråga användaren om en gissning, det som metoden returnerar hamnar i variabeln ***guess**.

I övrigt använder jag variabeln ***guesses*** för att hålla koll på antal frågor.

Om ***guess** är lika med ***number*** då har man vunnit.

Om ***guess** är mindre än ***number*** då har man gissat för högt.

Om ***guess** är större än ***number*** då har man gissat för lågt.

Efter 10 försök är spelet slut.