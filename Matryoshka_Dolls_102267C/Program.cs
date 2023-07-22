var input = Console.ReadLine()!.Split(" ");
var s = Convert.ToInt32(input[0]);
var x = Convert.ToInt32(input[1]);
var totalDolls = 0;
while (s != 0)
{
    s /= x;
    ++totalDolls;
}

Console.WriteLine(totalDolls);