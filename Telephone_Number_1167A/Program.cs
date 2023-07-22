int FindEight(int n, int[] duplicate)
{
    const int trumpCard = -3;
    var count = 0;

    for (var i = 0; i < n; i++)
    {
        ++count;
        if (duplicate[i] == 8)
        {
            var positionEight = i;
            return positionEight;
        }

        if (count == n) return trumpCard;
    }

    return -1; // default return value if no 8 is found
}

void IntConverter(int n, char[] arr, int[] duplicate)
{
    for (int i = 0; i < n; i++)
    {
        duplicate[i] = arr[i] - '0'; // converting string to int array
    }
}

var t = int.Parse(Console.ReadLine()!);

while (t-- > 0)
{
    var n = int.Parse(Console.ReadLine()!);
    var arr = Console.ReadLine()!.ToCharArray();
    var duplicate = new int[n];

    IntConverter(n, arr, duplicate);
    var looper = FindEight(n, duplicate);

    var count = 0;

    if (looper >= 0)
        for (var i = looper + 1; i < n; i++)
            ++count;


    switch (count)
    {
        case >= 10:
            Console.WriteLine("YES");
            break;
        default:
            Console.WriteLine("NO");
            break;
    }
}