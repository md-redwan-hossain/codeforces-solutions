int countZ = 0, countN = 0;
Console.ReadLine();
var str = Console.ReadLine();

foreach (var item in str!)
{
    switch (item)
    {
        case 'z':
            ++countZ;
            break;
        case 'n':
            ++countN;
            break;
    }
}


while (countN != 0)
{
    Console.WriteLine("1 ");
    --countN;
}

while (countZ != 0)
{
    Console.WriteLine("0 ");
    --countZ;
}