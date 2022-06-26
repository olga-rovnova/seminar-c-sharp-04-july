//Задача 42: Напишите программу, 
//которая будет преобразовывать десятичное число в двоичное. 
// 45 -> 101101 
// 3  -> 11 
// 2  -> 10

int InputInt (string mes) 
{     
    Console.Write($"Insert {mes}: ");     
    return Convert.ToInt32(Console.ReadLine()); 
}  
int number = InputInt("number");

string result = string.Empty;

while (number>=2)
{
    result= Convert.ToString(number%2)+result;
    number = number/2;
}
result = Convert.ToString(number%2)+result;
Console.WriteLine(result);