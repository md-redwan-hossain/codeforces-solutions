var tempInput = Console.ReadLine()!.Split(" ");
var n = Convert.ToInt32(tempInput[0]);
var m = Convert.ToInt32(tempInput[1]);
int row;

for (row = 1; row <= n; row++)
{
    if (row % 4 == 0)
    {
        Console.Write("#");
    }

    int column;
    for (column = 1; column <= m - 1; column++)
    {
        if (row % 2 != 0)
        {
            Console.Write("#");
        }

        if (row % 2 == 0 && row % 4 != 0)
        {
            Console.Write(".");
        }

        if (row % 4 == 0)
        {
            Console.Write(".");
        }
    }

    if (row % 2 != 0)
    {
        Console.Write("#");
    }

    if (row % 2 == 0 && row % 4 != 0)
    {
        Console.Write("#");
    }

    Console.Write("\n");
}