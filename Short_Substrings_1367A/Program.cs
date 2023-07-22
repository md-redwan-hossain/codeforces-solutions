var n = int.Parse(Console.ReadLine()!);

for (var i = 0; i < n; i++)
{
    var arr = Console.ReadLine();

    for (var x = 0; x < arr!.Length; x++)
    {
        if (x == 0 || x % 2 == 0 || x == arr.Length - 1)
            Console.Write(arr[x]);
        // print the even index
        // also print the last index that contains a character
    }

    Console.WriteLine();
    // newline is required for taking new input at new line
}