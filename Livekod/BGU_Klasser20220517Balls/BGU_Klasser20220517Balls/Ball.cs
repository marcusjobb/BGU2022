namespace BGU_Klasser20220517Balls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Ball
{
    int XDir = 1; // Riktning på objektet
    int X = 1; // Objektets position
    int YDir = 1;
    int Y = 1;

    // Constructorn
    public Ball(int xDir, int yDir, int x, int y)
    {
        XDir = xDir;
        YDir = yDir;
        X = x;
        Y = y;
    }

    public void MoveBall()
    {
        // Radera bollen
        PrintBall(X, Y, " ");

        // Ändra bollens position med ett steg i riktning
        // som anges av XDir
        X += XDir; // Öka X med värdet på XDir
        Y += YDir; // Öka Y med värdet på YDir

        //Skriv ut bollen
        PrintBall(X, Y, "O");

        // Om X är större än gränsen för skärmen
        // eller X är mindre än gränsen för skärmen
        // Byt riktning
        XDir = GetBoundaries(1, 100, X, XDir);
        YDir = GetBoundaries(1, 24, Y, YDir);
    }

    int GetBoundaries(int lowest, int highest, int position, int direction)
    {
        var dir = Math.Abs(direction); // Matte absolutvärde
        if(position > highest) return -dir;
        else if(position < lowest) return dir;
        else
            return direction;
    }

    void PrintBall(int x, int y, string ball)
    {
        if(x < 1) x = 1;
        if (y<1) y = 1;

        Console.SetCursorPosition(x, y);
        Console.Write(ball);
    }
}
