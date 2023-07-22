Console.ReadLine();
var events = (Console.ReadLine()!).Split(" ");

var crime = 0;
var police = 0;

foreach (var item in events)
{
    if (item == "-1")
    {
        if (police > 0)
            --police;

        else
            ++crime;
    }

    else if (item != "-1")

        police += int.Parse(item);
}

Console.WriteLine(crime);