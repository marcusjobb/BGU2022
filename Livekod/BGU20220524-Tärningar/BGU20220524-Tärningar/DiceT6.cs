namespace DiceClasses
{
    // See https://aka.ms/new-console-template for more information
    // Mål:
    // Vi ska skapa en klass som representerar en T6 tärning, den ska vi sedan
    // ärva och skapa en T20 istället.
    // CTRL + SHIFT + A = Ny klass i Visual Studio!
    // KLassen ska ha metoden Roll() som returnerar tärningsvärdet
    // Klassen ska också ha en property som visar värdet

    // public = Alla kan nå den
    // private = bara samma namespace kan nå det
    // ingenting = private
    // internal = bara samma projekt kan nå det
    // protected = tillgänglig för egna klassen och klasser som ärver den
    //             för alla andra är den private
    public class DiceT6
    {
        private int value;
        protected int maxValue = 6;
        // Propertyn beter sig som en variabel utåt
        public int Value
        {
            get { return value; } // ger värdet tillbaka
            //set { this.value = value; } // sätter värdet
        }

        public int Roll()
        {
            Random rnd = new Random();
            value = rnd.Next(1, maxValue + 1);
            return value;
        }
    }

    public class DiceT20 : DiceT6
    {
        public DiceT20()
        {
            // Kan använda maxValue för att den är "protected" och klassen ärver T6
            maxValue = 20;
        }
    }

    public class DiceT3 : DiceT6
    {
        public DiceT3()
        {
            // Kan använda maxValue för att den är "protected" och klassen ärver T6
            maxValue = 3;
        }
    }
}