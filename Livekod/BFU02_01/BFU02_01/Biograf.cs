using System;

namespace BFU02_01
{
    public class Biograf
    {
        private int Age = 51;
        private int Hour = 16;
        private int Month = 6;
        public Biograf()
        {
            BiljettPris = 120;
        }

        public double BiljettPris { get; set; }
        public void Run()
        {
            FrågaOmTid();
            if (Hour > 16)
            {
                FrågaOmMånad();
                if (Month < 5 || Month > 8) FrågaOmÅlder();
            }
            VisaBiljettpris();
        }

        private void FrågaOmMånad()
        {
            Console.WriteLine("Vilken månad gäller det?");
            var month = Console.ReadLine();
            Month = int.Parse(month);
        }

        private void FrågaOmTid()
        {
            Console.WriteLine("Vilken timme vill du gå?");
            var hour = Console.ReadLine();
            Hour = int.Parse(hour);
        }

        private void FrågaOmÅlder()
        {
            Console.WriteLine("Hur gammal är du?");
            var age = Console.ReadLine();
            Age = int.Parse(age);
        }

        private void VisaBiljettpris()
        {
            var price = BiljettPris;
            if (Hour < 16) price -= BiljettPris * .30;
            else if (Month >= 5 && Month <= 8) price -= BiljettPris * .15;
            else if (Age < 12 || Age >= 62) price -= BiljettPris * .20;

            Console.WriteLine($"Din biljettpris kostar {price}kr");
        }
    }
}