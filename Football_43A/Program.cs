var totalTestCase = int.Parse(Console.ReadLine()!);
var dict = new Dictionary<string, int>();

while (totalTestCase != 0)
{
    var goal = Console.ReadLine()!;
    if (dict.ContainsKey(goal))
    {
        var currentGoalCount = dict[goal];
        ++currentGoalCount;
        dict[goal] = currentGoalCount;
    }
    else dict.Add(goal, 1);

    --totalTestCase;
}


var arrKeys = dict.Keys.ToArray();
var arrVal = dict.Values.ToArray();
if (arrKeys.Length == 1)
    Console.WriteLine(arrKeys[0]);
else
    Console.WriteLine(arrVal[0] > arrVal[1] ? arrKeys[0] : arrKeys[1]);