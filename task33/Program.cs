/*Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве. 4; 
массив [6, 7, 19, 345, 3] -> нет 3; 
массив [6, 7, 19, 345, 3] -> да */

// Вариант_1
// int InputInt (string mes) 
// {     
//     Console.Write($"Insert {mes}: ");     
//     return Convert.ToInt32(Console.ReadLine()); 
// }  

// void PrintArr(int[] a)          //печать массива 
// {     
//     Console.Write("[");     
//     for (int i = 0; i < a.Length - 1; i++)     
//     {         
//         Console.Write(a[i] + ", ");     
//     }     Console.Write(a[a.Length-1] + "]");     
//     Console.WriteLine(); 
// }   

// int length = InputInt("Array Length"); 
// int[] array = new int[length]; 
// int num = InputInt("Number");  

// for (int i = 0; i < length; i++) 
// {     
//     array[i]= InputInt($"element {i}"); 
// }  PrintArr(array); 

// bool flag = false; 

// for (int i = 0; i < length; i++)
// {
//     if (num == array[i])
//     {
//         flag = true;
//         break;
//     }
// }

// Console.Write(flag);

// Вариант_2
// int[] array = new int[4];
// int ck = Input("число проверки:");
// int b = 0; FillArrayRandomNumbers(array);

// PrintArray(array);
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == ck)
//     {
//         b++;         //Console.Write("ДА");         //break;         
//     }
//     if (array[i] == ck * (-1))
//     {
//         b++;         //Console.Write("ДА");         //break;         
//     }
//     //else         //Console.Write("ДА"); 
// }

// if (b == 0)
// {
//     Console.Write("НЕТ");
// }
// else
// {
//     Console.Write("ДА");
//     Console.Write(b);
// } //PrintArray(array); 

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void FillArrayRandomNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Input("Число:");
//     }
// }

// int Input(string output)
// {
//     Console.Write(output);
//     return Convert.ToInt32(Console.ReadLine());
// }

//Вариант_3
bool SearchNumber(int[] array, int number)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == number)
            return true;
    }
    return false;
}
//Создание массива:
int size = InputInt("Введите размер массива: "); 
int[] array = CreateArray(size); 
PrintArray(array);  

int[] CreateArray(int size) 
{     
    int[] array = new int[size];     
    for(int i = 0; i < array.Length; i++)     
    {         
        array[i] = InputInt("Введите элемент " + i + ": ");     
    }     return array; 
}  

int InputInt(string outout) 
{     
    Console.Write(outout);     
    return Convert.ToInt32(Console.ReadLine()); 
}  

void PrintArray(int[] array) 
{     
    for(int i = 0; i < array.Length; i++)     
    {         
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
