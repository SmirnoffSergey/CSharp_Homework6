// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Задайте количество вводимых чисел, М = ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Введите числа через Enter");
int count = 0;
for (int i = 1; i <= M; i++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) count++;
}

Console.WriteLine($"Количество чисел, которые больше нуля, равно {count}");





// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и
// k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите коэффициенты уравнений двух прямых k1, b1, k2, b2 через Enter: ");
double b1 = Convert.ToDouble(Console.ReadLine());
double k1 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые параллельны друг другу");
if (k1 != k2) Console.WriteLine($"Прямые, заданные уравнениями y = {k1}x + {b1} и y = {k2}x + {b2}, пересекаются в точке ({(b2 - b1) / (k1 - k2)}; {k1 * ((b2 - b1) / (k1 - k2)) + b1})");