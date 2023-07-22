var totalTestCase = int.Parse(Console.ReadLine()!);
while (totalTestCase != 0)
{
    var testCase = Console.ReadLine()!.Split(" ");

    var firstDigit = int.Parse(testCase[0]);
    var secondDigit = int.Parse(testCase[1]);
    var thirdDigit = int.Parse(testCase[2]);

    if (firstDigit + secondDigit >= 10 || firstDigit + thirdDigit >= 10 || secondDigit + thirdDigit >= 10)
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO");

    --totalTestCase;
}