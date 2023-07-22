var n = int.Parse(Console.ReadLine()!);
var input = Console.ReadLine()!.Split(" ");
var arr = new List<int>();

foreach (var item in input)
{
    arr.Add(int.Parse(item));
}

var min = arr[0];
var minIndex = 0;
var max = arr[0];
var maxIndex = 0;

for (var i = 0; i < n; i++)
{
    if (min >= arr[i])
    {
        min = arr[i];
        minIndex = i;
    }

    if (max < arr[i])
    {
        max = arr[i];
        maxIndex = i;
    }
}

if (minIndex < maxIndex)
{
    minIndex = (n - 1) - minIndex;
    Console.WriteLine(minIndex + maxIndex - 1);
}
else
{
    minIndex = (n - 1) - minIndex;
    Console.WriteLine(minIndex + maxIndex);
}