var inputStr = Console.ReadLine()!.Replace('+', ' ').Split(" ");
Array.Sort(inputStr);
Console.WriteLine(string.Join('+', inputStr));
