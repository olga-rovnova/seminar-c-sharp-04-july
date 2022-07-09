// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int first = -3;
int second = 5;
int count = second - first + 1;
int sum = 0;

Console.WriteLine(Sum(first, count));

int Sum(int first, int count)
{
    if (count == 0)
    {
        return 0;
    }
    else
    {
        return sum = first + Sum(++first, --count);
        
    }
}
