var totalTestCase = int.Parse(Console.ReadLine()!);


while (totalTestCase != 0)
{
    Console.ReadLine();
    var input = Console.ReadLine()!;
    var badLetter = 0;

    foreach (var item in input)
    {
        if (item == ')') ++badLetter;
        else badLetter = 0;
    }

    Console.WriteLine(input.Length - badLetter < badLetter ? "Yes" : "No");
    --totalTestCase;
}