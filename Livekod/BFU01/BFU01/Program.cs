namespace BFU01
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // #1
            Console.WriteLine("Batman!");

            // #2
            Console.WriteLine("Vem är din favoritsuperhjälte");
            string superhero = Console.ReadLine();
            Console.WriteLine("Din favoritsuperhjälte är " + superhero);

            // #3
            Console.WriteLine("Skriv in ett tal");
            string num1 = Console.ReadLine();
            Console.WriteLine("Skriv in ett tal till");
            string num2 = Console.ReadLine();

            Console.WriteLine("Heltal");
            int intAdd = int.Parse(num1) + int.Parse(num2);
            int intSub = int.Parse(num1) - int.Parse(num2);
            int intMul = int.Parse(num1) * int.Parse(num2);
            int intDiv = int.Parse(num1) / int.Parse(num2);
            Console.WriteLine("Addition       : " + intAdd);
            Console.WriteLine("Subtraktion    : " + intSub);
            Console.WriteLine("Multiplikation : " + intMul);
            Console.WriteLine("Division       : " + intDiv);

            Console.WriteLine("Med decimaler");
            double doubleAdd = double.Parse(num1) + double.Parse(num2);
            double doubleSub = double.Parse(num1) - double.Parse(num2);
            double doubleMul = double.Parse(num1) * double.Parse(num2);
            double doubleDiv = double.Parse(num1) / double.Parse(num2);
            Console.WriteLine("Addition       : " + doubleAdd);
            Console.WriteLine("Subtraktion    : " + doubleSub);
            Console.WriteLine("Multiplikation : " + doubleMul);
            Console.WriteLine("Division       : " + doubleDiv);

            // #4
            Console.WriteLine("Skriv ditt namn:");
            string namn = Console.ReadLine();
            var first = namn[0];
            Console.WriteLine(namn + first);
            Console.WriteLine("Ange ett nummer, max (" + namn.Length + ")");
            var posText = Console.ReadLine();
            int pos = int.Parse(posText);
            var bokstav = namn[pos - 1];
            Console.WriteLine(bokstav + namn + first);

            // #5
            bool a = true;
            bool b = true;
            Console.WriteLine($"a={a}, b={b} \t \t ---> a && b = {a && b}  a || b = {a || b}");
            a = true;
            b = false;
            Console.WriteLine($"a={a}, b={b} \t ---> a && b = {a && b}  a || b = {a || b}");
            a = false;
            b = false;
            Console.WriteLine($"a={a}, b={b} \t ---> a && b = {a && b}  a || b = {a || b}");
            a = true;
            b = false;
            Console.WriteLine($"a={a} \t\t --> not a {!a}");
            Console.WriteLine($"a={b} \t --> not b {!b}");

        }
    }
}
