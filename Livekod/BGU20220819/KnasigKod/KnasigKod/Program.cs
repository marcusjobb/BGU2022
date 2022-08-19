namespace KnasigKod
{
    internal class Program
    {
        // Knasigkod.Program.Main();
        static void Main()
        {
            int tal1 = 0;
            int tal2 = 0;
            Console.WriteLine("Ange två tal");

            //Console.Write("Tal 1 :");
            //string input = Console.ReadLine();
            //tal1 = int.Parse(input);
            tal1 = AskForIt("Tal 1 : ");

            //Console.Write("Tal 2 :");
            //input = Console.ReadLine();
            //tal2 = int.Parse(input);
            tal2 = AskForIt("Tal 2 : ");

            Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}");
        }

        static int AskForIt(string text) // inparameter : Text är en sträng
        {
            int value = 0;
            Console.Write(text);
            string input = Console.ReadLine();
            
            // tryParse returnerar false om talet är text
            if (int.TryParse(input,out value) == false)
            {
                Console.WriteLine("Pucko! Ange ett tal!");
                value = 0;
            }

            return value;
        }

    }
}