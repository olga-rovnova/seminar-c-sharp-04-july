// задача 42. Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] numbers = {1, 2, 3, 4, 5, 6};  
for (int i = 0; i < numbers.Length / 2; i++) 
{     
    int temp = numbers[i];     
    numbers[i] = numbers[numbers.Length - 1 - i];     
    numbers[numbers.Length - 1 - i] = temp; 
}  
for(int i = 0; i < numbers.Length; i++) 
{     
    Console.Write(numbers[i] + " ");
}

//Другой способ: (перезаписываем в др.массив)
// int[] numbers = {1, 2, 3, 4, 5}; 
// int[] tempArray = new int[numbers.Length];  
// for(int i = 0; i < numbers.Length; i++) 
// {     
//     tempArray[i] = numbers[numbers.Length - 1 - i]; 
// }  numbers = tempArray;  
// for(int i = 0; i < numbers.Length; i++) 
// {     
//     Console.Write(numbers[i] + " ");
// }

