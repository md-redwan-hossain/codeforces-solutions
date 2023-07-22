var testCase = (Console.ReadLine()!).Split(" ");
var dict = new Dictionary<int, bool>();

foreach (var item in testCase)
{
    if (!dict.ContainsKey(int.Parse(item)))
        dict.Add(int.Parse(item), true);
}

Console.WriteLine(testCase.Length - dict.Count);