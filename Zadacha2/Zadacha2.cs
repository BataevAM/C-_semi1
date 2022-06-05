Console.WriteLine("Введите два числа");
Console.WriteLine("Первое число: ");
int na = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int nb = Convert.ToInt32(Console.ReadLine());

if (na > nb)
{
    Console.Write("Большее число: ");
    Console.WriteLine(na);
    Console.Write("Меньшее число: ");
    Console.WriteLine(nb);
}
else if (na < nb)
{
    Console.Write("Меньшее число: ");
    Console.WriteLine(na);
    Console.Write("Большее число: ");
    Console.WriteLine(nb);
}