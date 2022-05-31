// Lånar klassen från ett annat program
using DiceClasses;
DiceT6 dice = new DiceT6();
DiceT20 dice20 = new DiceT20();
DiceT3 dice3 = new DiceT3();
for(int slag = 0; slag < 10; slag++)
{
    dice.Roll();
    Console.WriteLine(" T6: " + dice.Value); // {get;}

    dice20.Roll();
    Console.WriteLine("T20: " + dice20.Value); // {get;}

    dice3.Roll();
    Console.WriteLine(" T3: " + dice3.Value); // {get;}
}