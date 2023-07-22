var input = (Console.ReadLine()!).Split(" ");

if (int.Parse(input[1]) >= int.Parse(input[0]) && int.Parse(input[2]) >= int.Parse(input[0]))
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");