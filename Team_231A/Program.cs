var totalProblemSet = Convert.ToInt32(Console.ReadLine());
var result = 0;
while (totalProblemSet != 0)
{
    var tempResult = 0;
    var collectiveChoices = Console.ReadLine();
    var choices = collectiveChoices?.Split(" ");
    foreach (var item in choices!)
    {
        if (Convert.ToInt32(item) > 0) ++tempResult;
    }

    if (tempResult > 1) ++result;

    --totalProblemSet;
}

Console.WriteLine(result);