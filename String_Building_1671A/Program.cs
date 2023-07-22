var test = int.Parse(Console.ReadLine()!);
while (test-- > 0)
{
    var str = Console.ReadLine()!;
    var result = true;
    for (var i = 0; i < str.Length; i++)
    {
        var c = 1;
        while (i + 1 < str.Length && str[i] == str[i + 1])
        {
            c++;
            i++;
        }

        if (c < 2)
        {
            result = false;
            break;
        }
    }

    Console.WriteLine(result ? "YES" : "NO");
}