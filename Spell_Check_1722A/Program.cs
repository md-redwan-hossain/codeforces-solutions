var totalTestCase = int.Parse(Console.ReadLine()!);


while (totalTestCase != 0)
{
    Console.ReadLine();
    var input = Console.ReadLine()!;

    if (input.Length != 5) Console.WriteLine("NO");
    else
    {
        if (input.Contains("T") && input.Contains("i") && input.Contains("m") && input.Contains("u") &&
            input.Contains("r"))
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }


    --totalTestCase;
}