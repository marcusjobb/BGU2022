# Feedback

Spelet är spännande och fungerar bra!

Blev riktigt orolig när jag gissade fel och vattnet började forsa in :open_mouth:

Strukturen på koden är smart skriven men kan lätt bli rörig om spelet utvecklas mer (exempelvis om du ska skriva att det var *för mycket till höger men ändå nära* eller *för mycket till höger och väldigt långt bort*). 

Det är allmänt sätt inte rekommenderat att man lägger mycket kod i en Try-Catch. I detta fall fungerar det för att koden är ganska liten, men så fort programmet växer kommer lösningen att bli lite rörig.

Om man gissar rätt eller fel så ändras meddelandet bara med ordet 
"höger" eller "vänster", så du hade kunnat använda en metod som tar 
emot en parameter för riktning skriver ut: 

```cs
private void SkrivFeedback(string riktning)
{
	Console.WriteLine("Du gissade för långt till "+ riktning+ ", du hör en vattensluss öppnas och mer vatten forsar in i rummet!");
}
```

Bra kommentarer och bra namngivning på variabler och metoder. 
**Du kommer att bli en grym kodare!**

