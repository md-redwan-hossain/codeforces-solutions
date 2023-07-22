var loop = Convert.ToInt32(Console.ReadLine());


while (loop != 0)
{
    var size = Convert.ToInt32(Console.ReadLine());
    var arr = new int[size];
    var dummy = Console.ReadLine()!.Split(" ");
    for (var i = 0; i < size; i++) arr[i] = Convert.ToInt32(dummy[i]);

    if (size % 2 == 0)
    {
        for (int i = 0, j = size - 1; i < j; i++)
        {
            Console.Write(arr[i]);
            Console.Write(" ");
            Console.Write(arr[j]);
            Console.Write(" ");
            j--;
        }
    }
    else
    {
        for (int i = 0, j = size - 1; i <= j; i++)
        {
            Console.Write(arr[i]);
            Console.Write(" ");
            if (i < j)
            {
                Console.Write(arr[j]);
                Console.Write(" ");
                j--;
            }
        }
    }

    --loop;
}