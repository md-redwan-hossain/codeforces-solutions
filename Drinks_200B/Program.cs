var n = int.Parse(Console.ReadLine()!);
var input = Console.ReadLine()!.Split(" ");

var total = 0.0;
foreach (var item in input)
{
    total += int.Parse(item);
}

var ans = total / n;
Console.WriteLine(ans.ToString("F12"));