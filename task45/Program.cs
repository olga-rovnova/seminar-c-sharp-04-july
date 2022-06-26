// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void PrintArray(int[] a)  //печать массива 
{     
    Console.Write("[");     
    for (int i = 0; i < a.Length - 1; i++)     
    {         
        Console.Write(a[i] + ", ");     
    }     
    Console.Write(a[a.Length-1] + "]");     
    Console.WriteLine(); 
}   
int[] arrayOriginal = {4,5,6,7,89,13,66};
int[] arrayCopy = new int[arrayOriginal.Length];

for (int i = 0; i < arrayOriginal.Length; i++)
{
    arrayCopy[i] = arrayOriginal[i];
}

PrintArray(arrayCopy);

