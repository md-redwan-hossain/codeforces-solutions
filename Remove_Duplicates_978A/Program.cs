Console.ReadLine();
var input = Console.ReadLine()!.Split(" ");
var list = new List<string>();


for (var i = 0; i < input.Length; i++)
{
    var number = input[i];
    var duplicate = false;
    for (var j = i + 1; j < input.Length; j++)
    {
        if (number == input[j])
        {
            duplicate = true;
            break;
        }
    }

    if (!duplicate) list.Add(number);
}

Console.WriteLine(list.Count);
foreach (var item in list)
{
    Console.Write(item);
    Console.Write(" ");
}