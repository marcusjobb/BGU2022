namespace mittProgram
{
    class Program
    {
        public static void Main()
        {
            Console.CursorVisible = false;
            Boll boll = new Boll(50,3);
            Boll boll2 = new Boll(10, 10);
            while (true)
            {
                boll.DeleteBall();
                boll2.DeleteBall();
                boll.MoveBall();
                boll2.MoveBall();
                boll.DrawBall();
                boll2.DrawBall();
                System.Threading.Thread.Sleep(150);
            }
        }
    }


    class Boll
    {
        private int x = 10;
        private int y = 10;
        private int dx = 1; // direction X
        private int dy = 1; // direction Y

        public Boll(int x, int y) // constructor
        {
            this.x = x;
            this.y = y;
        }
        public void DrawBall()
        {
            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.WriteLine("O");
        }
        public void DeleteBall()
        {
            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.WriteLine(" ");
        }

        // Draw a ball
        public void Ball()
        {

        }


        public void MoveBall()
        {
            if (x > 100) dx = -1;
            if (y > 20) dy = -1;
            if (y < 1) dy = 1;
            if (x < 1) dx = 1;

            x = x + dx;
            y = y + dy;
        }
    }
}

