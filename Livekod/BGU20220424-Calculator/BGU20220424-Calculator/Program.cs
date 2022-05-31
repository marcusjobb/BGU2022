Console.WriteLine("Kalkylator");

int value1 = AskForNumber("Ange tal 1");
string function = AskForAText("Ange räknesätt");
int value2 = AskForNumber("Ange tal 2");
Output(value1, function, value2);

int Calculator(int a, string f, int b)
{
    return f switch
    {
        "+" => Add(a, b),
        "-" => Sub(a, b),
        "*" => Multi(a, b),
        "/" => Div(a, b),
        _ => 0
    };
}

int Add(int a, int b)
{
    return a + b;
}
int Sub(int a, int b)
{
    return a - b;
}
int Multi(int a, int b)
{
    return a * b;
}
int Div(int a, int b)
{
    return a / b;
}

int AskForNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

string AskForAText(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine() ?? "";
    return input;
}

void Output(int val1, string function, int val2)
{
    int result = Calculator(val1, function, val2);
    Console.WriteLine(val1 + " " + function + " " + val2 + " = " + result);
}