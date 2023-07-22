bool IsDisliked(int n)
{
    return n % 3 == 0 || n % 10 == 3;
}

int FindKthElement(int k)
{
    var count = 0;
    var num = 1;
    while (count <= k)
    {
        if (!IsDisliked(num))
        {
            count++;
            if (count == k)
                return num;
        }

        num++;
    }

    return -1;
}

var t = int.Parse(Console.ReadLine()!);

for (var i = 0; i < t; i++)
{
    var k = int.Parse(Console.ReadLine()!);
    var result = FindKthElement(k);
    Console.WriteLine(result);
}