# Programbeskrivning
Frågar om ålder och talar om vad man får köra. Det är i stort 
sett likadant som det första exemplet, men här har vi ändrat
på if-satsen för att koden ska bli mer läsbart. Det anses god sed
enligt kod-gurun "Uncle Bob" att när man kör en if-sats med else 
så ska man alltid hantera "true" svaret först.

```cs
if (answer == true) // kan även skrivas som if (answer)
{
	DoThis();
}
else
{
	DoThat();
}
``` 
är alltid snyggare än
```cs
if (answer == false) // kan även skrivas som if (!answer)
{
	DoThat();
}
else
{
	DoThis();
}
``` 


## Förklaringar
+ Vi definierar **age** variabeln först så att den ska finnas tillgänglig för alla delar av programmet
+ If-satsen är lite snyggare i den här versionen

## Att fundera på
+ Om åldern är mindre än 5, vad händer då?
+ Om användaren skriver "Tjugo" iställer för 20, vad händer då?

## Exempelkörning
```
Hur gammal är du?
21
Du kan köra:
* Cykel
* Moped
* Bil
* Tung mc
```

## Pseudokod
```
Sätt heltal "age" till 0 som standardvärde

FRÅGA "Hur gammal är du?"
	lagra svaret i age variabeln

OM age >= 95
	Skriv "Du får ta en taxi"
ANNARS
	Skriv "Du får köra"
	om age> 5 skriv "Cykel"
	om age >= 15 skriv "Moped"
	om age >= 18 skriv "Bil"
	om age >= 21 skriv "Tung MC"
```

## Flödesschema

![Flödeschema](./AgeCheck2.png)


