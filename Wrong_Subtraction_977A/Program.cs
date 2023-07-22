var input = Console.ReadLine()!.Split(" ");
var number = int.Parse(input[0]);
var n = int.Parse(input[1]);
while (n != 0)
{
    var lastDigit = number % 10;
    if (lastDigit != 0) number -= 1;
    else number /= 10;
    --n;
}

Console.WriteLine(number);