Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());
int max = -1, max1 = -1;
while (n != 0)
{
  n = Convert.ToInt32(Console.ReadLine());
  if(n >= max)
{
    max1 = max;
    max = n;
}
else
if(n > max1)
{
    max1 = n;
}
}
Console.WriteLine(max1);