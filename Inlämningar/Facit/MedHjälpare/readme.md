# Gissa ett tal

## Spelhandling
Ett UFO är på väg att landa över din stad.

Ditt jobb är att skjuta upp en missil som spränger UFOt, så att den hemliga organisationen S.T.E.A.L kan stjäla deras information

Riktningen på missilen anges i en skala från 1 - 100

Din assistent kommer att hjälpa dig om du missar.

### Assistenten
Den enda skillnaden på den här versionen är att den anpassar texten "Gissa ett tak mellan 1 och 100" till exempelvis "Gissa ett tal mellan 30 och 75". Om man nu gissat mellan de talen. På så sätt så minskar den avståndet mellan gissningarna ju mer man gissar.

# Om koden
Koden är en omstrukturerad version av koden i [första exemplet](../../EnkelVersion)

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

## Metoderna
Här är en lista på alla metoder som används. Metoderna hade lika gärna kunnat vara en del av ***Start()*** men det känns enklare att ha skilda metoder så att koden blir lättare att hantera. Om något går fel ändrar man i den specifika metoden istället för att bli tvungen att läsa all koden för att hitta var felet är.

### bool EvaluateChoice(char choice)
Utvärdera om spelaren tryckt F eller G

### AskToPlayAgain()
Lockar spelaren till att spela igen

### ShowResult(int guesses)
Tar emot antal gissningar som gjorts och berättar hur det har gått

### GetGuess()
Frågar användaren om en gissning och kollar så att användaren angett ett tal

### ShowStats(int guesses)
Visar var UFOt befinner sig (baserat på antal gissningar kvar)

### ShowIntro()
Visar intro till spelet

