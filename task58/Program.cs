// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number;

Console.WriteLine(Numbers(number, count));

string Numbers(int number, int count)
{
    if (count == 0)
    {
        return string.Empty;
    }
    else
    {
        return number + " " + Numbers(number - 1, --count);
    }
}
