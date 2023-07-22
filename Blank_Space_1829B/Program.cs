var totalTestCase = int.Parse(Console.ReadLine()!);

while (totalTestCase != 0)
{
    Console.ReadLine();
    var testcase = Console.ReadLine()!.Split(" ");
    var counter = 0;
    var result = 0;

    foreach (var item in testcase)
    {
        switch (item)
        {
            case "0":
                ++counter;
                break;
            case "1":
            {
                if (result < counter) result = counter;
                counter = 0;
                break;
            }
        }
    }

    if (result < counter) result = counter;
    Console.WriteLine(result);
    --totalTestCase;
}