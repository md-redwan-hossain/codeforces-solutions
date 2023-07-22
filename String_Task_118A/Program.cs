var testCase = (Console.ReadLine()!);

var dict = new Dictionary<char, bool>()
{
    { 'A', true }, { 'O', true }, { 'Y', true }, { 'E', true }, { 'U', true }, { 'I', true },
};

var result = new System.Text.StringBuilder();

foreach (var item in testCase)
{
    if (!dict.ContainsKey(char.ToUpper(item)))
    {
        result.Append(".");
        result.Append(char.IsUpper(item) ? char.ToLower(item) : item);
    }
}

Console.WriteLine(result);