Console.WriteLine("Введите три числа");
Console.WriteLine("Первое число: ");
int na = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int nb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Третье число: ");
int nc = Convert.ToInt32(Console.ReadLine());
int max;

if (na > nb)
{
    max = na;
}
else 
{
    max = nb;
}
if (nc > max)
{
    max = nc;
}
Console.WriteLine("Максимальное число: ");
Console.WriteLine(max);