Console.Clear();

int xa = 1, ya = 20,
    xb = 40, yb = 20,
    xc = 40, yc = 1,
    xd = 1, yd = 1,
    rX1 = (xa + xb) / 2, rY1 = (ya + yb) / 2,
    rX2 = (xb + xc) / 2, rY2 = (yb + yc) / 2,
    rX3 = (xc + xd) / 2, rY3 = (yc + yd) / 2,
    rX4 = (xd + xa) / 2, rY4 = (yd + ya) / 2;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");
Console.SetCursorPosition(xd, yd);
Console.WriteLine("+");
// Console.SetCursorPosition(rX1, rY1);
// Console.WriteLine("+");
// Console.SetCursorPosition(rX2, rY2);
// Console.WriteLine("+");
// Console.SetCursorPosition(rX3, rY3);
// Console.WriteLine("+");
// Console.SetCursorPosition(rX4, rY4);
// Console.WriteLine("+");

int x = xa, y = ya;
int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 8);
    if (what == 0)
    {
        x = (x + 2 * xa) / 3;
        y = (y + 2 * ya) / 3;
    }
    if (what == 1)
    {
        x = (x + 2 * xb) / 3;
        y = (y + 2 * yb) / 3;
    }
    if (what == 2)
    {
        x = (x + 2 * xc) / 3;
        y = (y + 2 * yc) / 3;
    }
    if (what == 3)
    {
        x = (x + 2 * xd) / 3;
        y = (y + 2 * yd) / 3;
    }
    // if (what == 4)
    // {
    //     x = (x + 2 * rX1) / 3;
    //     y = (x + 2 * rY1) / 3;
    // }
    // if (what == 5)
    // {
    //     x = (x + 2 * rX2) / 3;
    //     y = (x + 2 * rY2) / 3;
    // }
    // if (what == 6)
    // {
    //     x = (x + 2 * rX3) / 3;
    //     y = (x + 2 * rY3) / 3;
    // }
    // if (what == 7)
    // {
    //     x = (x + 2 * rX4) / 3;
    //     y = (x + 2 * rY4) / 3;
    // }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1;
}
Console.SetCursorPosition(xa, ya + 1);