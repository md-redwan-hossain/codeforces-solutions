var year = int.Parse(Console.ReadLine()!);

while (true)
{
    year += 1;
    var firstDigit = year / 1000;
    var secondDigit = year / 100 % 10;
    var thirdDigit = year / 10 % 10;
    var fourthDigit = year % 10;
    if (firstDigit != secondDigit && firstDigit != thirdDigit && firstDigit != fourthDigit &&
        secondDigit != thirdDigit && secondDigit != fourthDigit && thirdDigit != fourthDigit)
        break;
}

Console.WriteLine(year);