int n, i;

Console.Write("Введите целое число: ");
while (!int.TryParse(Console.ReadLine(), out n))
    Console.Write("Данные не корректны, повторите ввод: ");
i = 0;
while (i <= n)
{
    if (i % 2 == 0)
    {
       Console.Write($"{i} ");
    }
    i++;
}