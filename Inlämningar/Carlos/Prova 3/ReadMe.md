#  Feedback

Aaw ett romantiskt och trollskt spel. Vem skulle inte vilja träffa en älva i skogen och man får gifta sig med henne om man gissar hennes ålder.  :heart: :fairy_woman: 

*Såvida inte vi pratar om älvkungen i Ghoetes dikt "[Erlkönig](https://sv.wikipedia.org/wiki/Erlk%C3%B6nig#%C3%96vers%C3%A4ttning_till_svenska)" för den alven var inte snäll!*
```
”Din fägring mig lockar, jag har dig så kär,  
jag tar dig med våld, om ej villig du är.”–  
Min far, min far, han hårt i mig tar,  
älvkungen gjort mig så illa, far!  
  
Sin häst han rysande sporrar i hast  
och håller det kvidande barnet fast.  
Sin gård omsider når han med nöd.  
Då låg i hans armar gossen död.

- Erlkönig av Ghoete
```

Mysigt spel och bra skriven kod, bra kommentarer. Tack o lov är ditt spel inte lika mörk som Ghoetes dikt. Bra form på dina If-else-satser. 

Den här raden är helt underbar!
```cs 
Console.WriteLine("Hej Mr. Don Giovanni om du vill gifta dig, behöver du att ange en siffra");
```

Det enda som förbryllar mig är rad 87
```cs
while(åldern != slumpTal && antalGissningar != gissnininggräns) 
```
Om åldern (gissning) inte är lika med slumptal och altalgissningar inte är lika med gissningsgräns så ska spelet loopa i all evighet. Nu kommer detta aldrig att inträffa då åldern kommer att vara lika med slumptal och då kommer sannolikt antal gissningar att vara inte lika med gissningsgräns. Om åldern inte är lika med slumptalet då kommer sannolikt antalgissningar att vara lika med gissningsgräns. I vilket fall kommer loopen aldrig att köras, så den raden behövs inte.