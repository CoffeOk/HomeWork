int x;
Console.Write("Введите целое число: ");
while(!int.TryParse(Console.ReadLine(), out x))
Console.Write("Данные не корректны, повторите ввод: ");
if (x % 2 == 0)
{
    Console.Write($"{x} -> чётное");
}
else
{
    Console.Write($"{x} -> нечётное");
}