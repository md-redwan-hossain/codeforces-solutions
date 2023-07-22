var input1 = Console.ReadLine()!.Split(" ");

var n = int.Parse(input1[0]);
var m = int.Parse(input1[1]);


using System;

var n = int.Parse(Console.ReadLine());
var m = int.Parse(Console.ReadLine());
var f = new int[1000];

for (var i = 0; i < m; ++i)
{
    f[i] = int.Parse(Console.ReadLine());
}

Array.Sort(f, 0, m);
var least = f[n - 1] - f[0];

for (var i = 1; i <= m - n; ++i)
{
    if (f[i + n - 1] - f[i] < least)
    {
        least = f[i + n - 1] - f[i];
    }
}

Console.WriteLine(least);
