//Задача 41: Пользователь вводит с клавиатуры числа через запятую. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("введите целые числа через запятую без пробелов: ");
string numbers = $"{Console.ReadLine()} ";

int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == ',')
    {
        int j=i+1;
        if (numbers[j] !='0' && numbers[j] !='-')
        count++;
    }
} 

if (numbers[0] !='0' && numbers[0] !='-')
{
    count++;
}

Console.WriteLine($"Количество положительных чисел, введенных пользователем: {count}");


// Console.WriteLine("введите целые числа через запятую без пробелов: ");
// string numbers = $"{Console.ReadLine()} ";

//Console.WriteLine(numbers);

// int countAll = 0;
// int countNegative = 0;
// int combin = 0;

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] == ',')
//     {
//         countAll++;
//     }
// }   
// Console.WriteLine($"Количество всех введенных чисел: {countAll=countAll+1}");

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] == '-')
//     {
//         countNegative++;
//     }
// }   
// Console.WriteLine($"Количество отрицательных чисел, введенных пользователем: {countNegative}");

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] == ',')
//     {
//         int j=i+1;
//         if (numbers[j] =='0')
//         combin++;
//     }
// }   
// Console.WriteLine($"Количество введенных чисел, равных нулю: {combin}");

// Console.WriteLine($"Количество положительных чисел, введенных пользователем: {countAll - countNegative - combin}");


