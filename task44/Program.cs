// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// int InputInt (string mes) 
// {     
//     Console.Write($"Insert {mes}: ");     
//     return Convert.ToInt32(Console.ReadLine()); 
// }  
// void PrintArray(int[] a)  //печать массива 
// {     
//     Console.Write("[");     
//     for (int i = 0; i < a.Length - 1; i++)     
//     {         
//         Console.Write(a[i] + ", ");     
//     }     
//     Console.Write(a[a.Length-1] + "]");     
//     Console.WriteLine(); 
// }  
// int size = InputInt("N"); 
// int [] arrayFibonacci = new int[size];  

// arrayFibonacci[0] = 0; 
// arrayFibonacci[1] = 1;  

// for (int i = 2; i < arrayFibonacci.Length; i++) 
// {     
//     arrayFibonacci[i]= arrayFibonacci[i-2]+arrayFibonacci[i-1];
// }

// PrintArray(arrayFibonacci);

Console.Write("Введите, сколько чисел нужно вывести: "); 
int n = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[n]; 

if(n > 0) 
{     
    array[0] = 0; 
} 
if(n > 1) 
{     
    array[1] = 1; 
}  
for(int i = 2; i < array.Length; i++) 
{     
    array[i] = array[i - 1] + array[i - 2];
}

for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
