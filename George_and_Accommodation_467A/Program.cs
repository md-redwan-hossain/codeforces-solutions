var result = 0;
var n = Convert.ToInt32(Console.ReadLine());

for (var i = 1; i <= n; i++)
{
    var collectiveInput = Console.ReadLine()!.Split(" ");
    var pi = Convert.ToInt32(collectiveInput[0]);
    var qi = Convert.ToInt32(collectiveInput[1]);
    if (qi - pi >= 2) result += 1;
}

Console.WriteLine(result);