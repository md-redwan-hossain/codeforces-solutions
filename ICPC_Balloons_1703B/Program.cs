var totalTestCase = int.Parse(Console.ReadLine()!);

while (totalTestCase != 0)
{
    var length = int.Parse(Console.ReadLine()!);
    var testcases = Console.ReadLine()!.ToCharArray();

    var set = new HashSet<char>();
    foreach (var item in testcases)
        set.Add(item);

    var doublePoints = set.Count() * 2;
    Console.WriteLine(doublePoints + (length - set.Count()));
    --totalTestCase;
}