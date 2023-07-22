var timer = 1;
var n = Convert.ToInt32(Console.ReadLine());


while (timer <= n)
{
    if (timer == 1) Console.Write("I hate");


    if (timer % 2 == 0) Console.Write(" that I love");


    if (timer % 2 != 0 && timer != 1) Console.Write(" that I hate");


    ++timer;
}

Console.Write(" it");