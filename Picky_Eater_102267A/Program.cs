var input = Console.ReadLine()!.Split(" ");
var currentMoney = Convert.ToInt32(input[0]);
var foodPrice = Convert.ToInt32(input[1]);

Console.WriteLine(currentMoney >= foodPrice ? 1 : 0);