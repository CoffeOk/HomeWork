//1. Программа принимает на вход число n
//2. Программа показывает все чётные числа от 1 до n


int n, i;

Console.Write("Введите целое число: ");
while (!int.TryParse(Console.ReadLine(), out n))
    Console.Write("Данные не корректны, повторите ввод: ");
i = 1;
while (i <= n)
{
    if (i % 2 == 0)
    {
       Console.Write($"{i} ");
    }
    i++;
}