# Pseudokod

```
START
    Spel mot datorn. 
        Hemligt framslumpat tal 1-100
        Tio gissningar
            Skriv gissning
                Om gissning för hög eller låg
                    spelet fortsätter om gissningar <10
                Om gissning rätt och gissningar <=10
                    spelet slut
                Om gissning fel och gissningar =10
                    spelet slut


SLUT
```

## Beskrivning
```
Ett spel som slumpar fram ett tal mellan 0-100 där spelaren får maximalt tio gånger på sig att gissa vilket tal det är. Storyn är att det är 100 boxar där en av dem
innehåller en diamant och resten bara en vanlig sten.

Programmet säger "Hej!" och ber spelaren gissa på ett värde 1 till 100.
Programmet slumpar fram ett tal 1-100. Spelaren gissar första gången av maximalt tio.

Om spelaren gissar för lågt svarar programmet att talet är för lågt och ber spelaren gissa igen.

Om spelaren gissar för högt svarar programmet att talet är för högt och ber spelaren gissa igen.

Om spelaren gissar rätt säger programmet "Grattis! Du vann!"

Efter en rätt gissning och/eller maximalt tio felaktiga avslutas spelet dvs programmet kör en loop max tio gånger och om spelaren gissar rätt inom de tio gångerna ska loopen avslutas.
```
