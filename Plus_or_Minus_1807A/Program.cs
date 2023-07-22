var totalTestCase = int.Parse(Console.ReadLine()!);

while (totalTestCase != 0)
{
    var testcase = Console.ReadLine()!.Split(" ");
    var a = int.Parse(testcase[0]);
    var b = int.Parse(testcase[1]);
    var c = int.Parse(testcase[2]);
    if (a + b == c) Console.WriteLine("+");
    else if (a - b == c) Console.WriteLine("-");
    --totalTestCase;
}