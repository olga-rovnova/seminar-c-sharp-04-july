/*Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)*/

// Console.Write("Введите k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите b1: "); 
// double b1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите k2: "); 
// double k2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите b2: "); 
// double b2 = Convert.ToInt32(Console.ReadLine());

int InputInt(string msg)
{
    Console.Write($"Введите {msg}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double k1 = InputInt("k1");
double b1 = InputInt("b1");
double k2 = InputInt("k2");
double b2 = InputInt("b2");

if (k1 != k2)
{
    double x = Math.Round((b2 - b1) / (k1 - k2),2);
    double y = k1 * x + b1;
    Console.WriteLine($"координаты точки пересечения прямых: x = {x}, y = {y}");
}
else Console.WriteLine($"прямые параллельны друг другу");

