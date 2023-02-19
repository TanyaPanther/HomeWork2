Console.Clear();

int dayNumber = ReadInt("Введите день недели от 1 до 7: ");
Console.WriteLine(Holiday(dayNumber));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
string Holiday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Выходной");
        }
        else
        {
            Console.Write("Не выходной");
        }
    }
    else
    {
        Console.Write("Введите число от 1 до 7 обозначающий");
    }
    return " день.";
}