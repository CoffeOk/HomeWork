//1. Программа принимает на вход три числа
//2. Программа показывает какое число меньшее


int a, b, c, max;
Console.Write("Введите число a: ");
while (!int.TryParse(Console.ReadLine(), out a))
    Console.WriteLine("Введите целое число");
Console.Write("Введите число b: ");
while (!int.TryParse(Console.ReadLine(), out b))
    Console.WriteLine("Введите целое число");
Console.Write("Введите число c: ");
while (!int.TryParse(Console.ReadLine(), out c))
    Console.WriteLine("Введите целое число");
max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write($"{a}, {b}, {c} -> {max}");