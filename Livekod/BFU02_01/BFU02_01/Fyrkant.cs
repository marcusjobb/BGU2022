using System;

namespace BFU02_01
{
    public class Fyrkant
    {
        private char Box = '█';
        private int Size = 10;

        public void Run()
        {
            FrågaOmStorlek();
            WriteBox();
        }

        private void FrågaOmStorlek()
        {
            Console.WriteLine("Hur stor ska fyrkanten vara?");
            var size = Console.ReadLine();
            Size = int.Parse(size);
        }

        private void WriteBox()
        {
            for (int y = 0; y < Size; y++)
            {
                Console.Write("   ");
                var width = y * 2.5;
                for (int x = 0; x < width; x++)
                {
                    Console.Write(Box);
                }
                Console.WriteLine();
            }
        }
    }
}