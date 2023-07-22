var str = Console.ReadLine();
var totalNumberOfA = 0;
var totalNumberOfOtherWords = 0;
var strSize = str?.Length;

foreach (var item in str!)
{
    if (item == 'a') ++totalNumberOfA;
    if (item != 'a') ++totalNumberOfOtherWords;
}


while (true)
{
    if (totalNumberOfA > totalNumberOfOtherWords)
    {
        Console.WriteLine(strSize);
        break;
    }
    else
    {
        --totalNumberOfOtherWords;
        --strSize;
    }
}