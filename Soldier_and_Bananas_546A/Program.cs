var input = Console.ReadLine()!.Split(" ");
var firstBananaPrice = int.Parse(input[0]);
var currentMoneyInPocket = int.Parse(input[1]);
var totalDesiredBanana = int.Parse(input[2]);
var totalMoneyNeeded = 0;


for (var i = 1; i <= totalDesiredBanana; ++i)
{
    var bananaPrice = i * firstBananaPrice;
    totalMoneyNeeded += bananaPrice;
}

var final = totalMoneyNeeded - currentMoneyInPocket;
Console.WriteLine(final >= 0 ? final : 0);