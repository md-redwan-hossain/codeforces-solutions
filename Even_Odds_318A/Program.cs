var input = Console.ReadLine()!.Split(' ');
var n = long.Parse(input[0]);
var k = long.Parse(input[1]);
var nOdds = n - n / 2;

if (k <= nOdds)
{
    Console.WriteLine(1 + ((k - 1) * 2));
}
else
{
    Console.WriteLine(2 + ((k - nOdds - 1) * 2));
}