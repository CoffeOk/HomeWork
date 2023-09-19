int n, i;

Console.Write("Введите целое число: ");
while (!int.TryParse(Console.ReadLine(), out n))
    Console.Write("Данные не корректны, повторите ввод: ");
for (i = 0; i <= n; i++)
    if (i % 2 == 0)
        Console.Write($"{i} ");

