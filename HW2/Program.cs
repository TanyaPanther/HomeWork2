Console.Clear();

int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.WriteLine(MakeArray(number, count));

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}