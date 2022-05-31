using System;

namespace BFU02_01
{
    public class GissaTal
    {
        private int Answer = 0;

        internal void Run()
        {
            var random = new Random();
            Answer = random.Next(0, 1000);
            SpelaFleraGånger();
        }

        private void SpelaFleraGånger()
        {
            var playItAgainSam = true;
            while (playItAgainSam)
            {
                Spela();
                Console.WriteLine("Vill du spela igen? (ja/nej)");
                var choice = Console.ReadLine();
                if (choice.ToLower()[0] == 'n') playItAgainSam = false;
            }
        }

        private void Spela()
        {
            var isRight = false;
            var guesses = 0;
            while (!isRight && guesses < 20)
            {
                Console.Write("Gissa på ett tal: ");
                var guess = GetInput();
                isRight = CheckGuess(guess);
                guesses++;
                CheckGuess(isRight, guess);
            }
            Feedback(guesses);
            Console.WriteLine($" {guesses} försök!");
        }

        private void CheckGuess(bool isRight, int guess)
        {
            if (!isRight)
            {
                Console.Write("Din gissning var ");
                GuessFeedback(guess);
            }
        }

        private bool CheckGuess(int guess) => guess == Answer;

        private static int GetInput()
        {
            var input = Console.ReadLine();
            var guess = int.Parse(input);
            return guess;
        }

        private void GuessFeedback(int guess)
        {
            if (guess < Answer)
            {
                Console.WriteLine("För låg");
            }
            else
            {
                Console.WriteLine("För hög");
            }
        }

        private static void Feedback(int guesses)
        {
            if (guesses < 20)
                Console.Write("Du klarade det på");
            else
                Console.Write("Du failade på");
        }
    }
}
