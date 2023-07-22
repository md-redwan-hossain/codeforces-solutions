var input = Console.ReadLine()!;
var arr = input.ToCharArray();
var duplicate = new int[arr.Length];

// converting string to int array
for (var i = 0; i < arr.Length; i++) duplicate[i] = arr[i] - '0';


var count = 0;
var size = duplicate.Length;

for (var i = 0; i < size - 1; i++)
{
    if (duplicate[i] == duplicate[i + 1]) ++count;

    if (duplicate[i] != duplicate[i + 1])
        if (count < 6)
            count = 0;
}

Console.WriteLine(count >= 6 ? "YES" : "NO");