var totalTestCase = int.Parse(Console.ReadLine()!);
while (totalTestCase != 0)
{
    var testCase = Console.ReadLine()!.Split(" ");
    var a = int.Parse(testCase[0]);
    var b = int.Parse(testCase[1]);


    if (a % b == 0)
        Console.WriteLine(0);
    else
        Console.WriteLine(b - (a % b));


    --totalTestCase;
}