var totalTestCase = int.Parse(Console.ReadLine()!);

while (totalTestCase != 0)
{
    var testcase = Console.ReadLine()!.Split("+");
    Console.WriteLine(int.Parse(testcase[0]) + int.Parse(testcase[1]));
    --totalTestCase;
}