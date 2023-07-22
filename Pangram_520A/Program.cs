var count = 0;
var traverse = new int[100];

var upto = int.Parse(Console.ReadLine()!);

var arr = Console.ReadLine()!.ToCharArray();

for (var i = 0; i < upto; i++)
{
    if (arr[i] >= 'a' && arr[i] <= 'z') arr[i] = (char)(arr[i] - 32);
    // if arr[i] is between a-z, make it uppercase
    // because it is more efficient to traverse through 26 array elements
    // that means run scan only for capital letters
    
    traverse[arr[i]] = 1;
    // counts letter and place them in the secondary counter array
}

for (var i = 0; i < 100; i++)
    count += traverse[i];
// increase count value according to traverse array's value


Console.WriteLine(count == 26 ? "YES" : "NO");