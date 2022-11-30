Console.Write("Введите число: ");
int var = int.Parse(Console.ReadLine());
int number = 2;
while (number <= var)
{
    Console.Write($"{number}, ");
    number += 2;
}