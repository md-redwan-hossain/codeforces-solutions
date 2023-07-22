var totalPeople = int.Parse(Console.ReadLine()!);
var opinions = Console.ReadLine()!.Split(" ");
var flag = false;

for (var i = 0; i < totalPeople; ++i)
{
    if (int.Parse(opinions[i]) == 1)
    {
        flag = true;
        break;
    }
}

if (flag) Console.WriteLine("HARD");
else Console.WriteLine("EASY");