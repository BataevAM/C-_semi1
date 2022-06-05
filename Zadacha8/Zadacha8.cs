Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 2;

Console.WriteLine("Четные числа в диапазоне от 1 до Вашего числа: ");
while(i<=n)
{
    Console.WriteLine(i);
    i = i + 2;
}