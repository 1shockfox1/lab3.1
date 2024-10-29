try
{
    double x = 24;
    Console.WriteLine("так изначально у них было " + x + "$");
    Console.WriteLine("Введите сегодняшний год");
    double god = double.Parse(Console.ReadLine());
    double itog = god - 1826;
    for (int i = 0; i < itog; i++)
    {
        x *= 1.06;
        
    }
    Console.WriteLine($"{x:F2} $");
}
catch
{
    Console.WriteLine("ошибочка 404.....");
}

