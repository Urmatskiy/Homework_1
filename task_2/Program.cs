Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine());
int max = first;
if (second > max)
{
    max = second;    
}
Console.WriteLine($"Наибольшим числом является {max}");