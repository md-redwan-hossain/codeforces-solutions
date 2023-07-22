var count = 0;
var upto = int.Parse(Console.ReadLine()!);
var dummy = (Console.ReadLine()!).Split(" ");

var arr = new int[upto];

for (var i = 0; i < upto; i++)
    arr[i] = int.Parse(dummy[i]);


var large = arr[0];

for (var i = 0; i < upto; i++)
{
    if (arr[i] > large)
        large = arr[i];
}

for (var i = 0; i < upto; i++)
{
    if (large == arr[i])
        continue;

    while (large > arr[i])
    {
        count++;
        arr[i]++;
    }
}

Console.WriteLine(count);