var n = int.Parse(Console.ReadLine()!);
var x = 0;
var arr = new string[n];

for (var i = 0; i < n; i++)
{
    arr[i] = Console.ReadLine()!;
    if (arr[i] == "++X" || arr[i] == "X++")

        x++;


    if (arr[i] == "--X" || arr[i] == "X--")

        x--;
}

Console.Write(x);