using BGU_Klasser20220517Balls;

Console.Clear();
Console.CursorVisible = false;

Ball[] Balls = new Ball[]
{
    new Ball(1, 1, 10, 10),
    new Ball(2, -1, 50, 5),
    new Ball(2, -1, 15, 15),
    new Ball(2, 0, 12, 12),
    new Ball(0, 1, 12, 12),
    new Ball(2, 1, 12, 12),
    new Ball(1, 1, 1, 1),
};

while(true)
{
    foreach(Ball ball in Balls)
    {
        ball.MoveBall();
    }

    Thread.Sleep(10); // Gör en paus
}
