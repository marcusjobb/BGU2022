Console.WriteLine("Hello, World!");

Calc miniräknare = new Calc(); // skapa en pepparkaksgubbe
int siffra = miniräknare.Subtract(10, 5);

Console.WriteLine(siffra);


class Calc
{ // pepparkaksform
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
}