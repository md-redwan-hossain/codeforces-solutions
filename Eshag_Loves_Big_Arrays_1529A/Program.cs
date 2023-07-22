var testCase = Convert.ToInt32(Console.ReadLine());
while (testCase != 0)
{
    var n = Convert.ToInt32(Console.ReadLine());
    var arr = new int[n];

    var dummy = Console.ReadLine()!.Split(" ");
    for (var i = 0; i < n; i++) arr[i] = Convert.ToInt32(dummy[i]);

    Array.Sort(arr);
    var lowest = arr[0];
    var result = 0;
    for (var i = 0; i < n; ++i)
    {
        if (arr[i] != lowest) break;
        ++result;
    }

    Console.WriteLine(n - result);
    --testCase;
}