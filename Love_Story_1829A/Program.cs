var totalTestCase = int.Parse(Console.ReadLine()!);

while (totalTestCase != 0)
{
    var testcase = Console.ReadLine()!;
    const string fixedStr = "codeforces";

    var counter = 0;
    for (var i = 0; i < testcase.Length; i++)
        if (testcase[i] != fixedStr[i])
            ++counter;

    Console.WriteLine(counter);
    --totalTestCase;
}