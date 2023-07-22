var totalTestCase = int.Parse(Console.ReadLine()!);

while (totalTestCase != 0)
{
    var testcase = Console.ReadLine();
    var firstPart = testcase!.Substring(0, 3);
    var secondPart = testcase.Substring(3, 3);

    var firstPartSum = 0;
    var secondPartSum = 0;

    foreach (var item in firstPart)
        firstPartSum += Convert.ToInt32(item);

    foreach (var item in secondPart)
        secondPartSum += Convert.ToInt32(item);

    Console.WriteLine(firstPartSum == secondPartSum ? "YES" : "NO");

    --totalTestCase;
}