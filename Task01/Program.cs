//Решение 1:

int a, b;
Console.Write("Введите число a: ");
while (!int.TryParse(Console.ReadLine(), out a))
    Console.WriteLine("Введите целое число");
Console.Write("Введите число b: ");
while (!int.TryParse(Console.ReadLine(), out b))
    Console.WriteLine("Введите целое число");
if (a > b)
{
    Console.WriteLine($"a = {a}, b = {b} -> max = {a}");
}
else
{
    Console.WriteLine($"a = {a}, b = {b} -> max = {b}");
}

//Решение2

// int a, b;
// Check_a:
// Console.Write("Vvedite chislo a: ");

// if (int.TryParse(Console.ReadLine(), out a))
// {
// Check_b:
//     Console.Write("Vvedite chislo b: ");

//     if (int.TryParse(Console.ReadLine(), out b))
//     {
//         goto Sravnenie;
//     }
//     else
//         Console.WriteLine("Введите целое число");
//     goto Check_b;
// }
// else
// {
//     Console.WriteLine("Введите целое число");
//     goto Check_a;
// }
// Sravnenie:
// if (a > b)
// {
//     Console.WriteLine($"a = {a}, b = {b} -> max = {a}");
// }
// else
// {
//     Console.WriteLine($"a = {a}, b = {b} -> max = {b}");
// }

// Решение3:

// int a, b;
// Console.Write("Vvedite chislo a: ");
// a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Vvedite chislo b: ");
// b = Convert.ToInt32(Console.ReadLine());
// if (a > b)
// {
//     Console.WriteLine($"a = {a}, b = {b} -> max = {a}");
// }
// else
// {
//     Console.WriteLine($"a = {a}, b = {b} -> max = {b}");
// }