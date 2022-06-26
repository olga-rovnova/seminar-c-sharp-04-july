// Задача 35: Задайте одномерный массив из 123 случайных чисел.  
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].  
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123 
// [5, 18, 123, 6, 2] -> 1 
// [1, 2, 3, 6, 2] -> 0 
// [10, 11, 12, 13, 14] -> 5

int InputInt (string mes) 
{     
    Console.Write($"Insert {mes}: ");     
    return Convert.ToInt32(Console.ReadLine()); 
}  

void PrintArr(int[] a)              //печать массива 
{     
    Console.Write("[");     
    for (int i = 0; i < a.Length - 1; i++)     
    {         
        Console.Write(a[i] + ", ");     
    }     Console.Write(a[a.Length-1] + "]");     
    Console.WriteLine(); 
}   

int[] array = new int[123];  
for (int i = 0; i < array.Length; i++) 
{     
    array[i] = new Random().Next(0,1000); 
}  
PrintArr(array);

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i]>9 && array[i]<100)
    {
        count++;
    }
}
Console.Write(count);