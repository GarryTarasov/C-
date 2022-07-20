// Задача №1Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
//а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число (А)");
int number_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число (B)");
int number_B = Convert.ToInt32(Console.ReadLine());

if (number_A > number_B)
{
        Console.WriteLine(number_A + " больше " + number_B);
}
else
{
if(number_A < number_B)
{
    Console.WriteLine(number_A + " меньше " + number_B);
}
    else
    {
    }
    if(number_A=number_B)
    {
        Console.WriteLine(number_A+ " равны " + number_B);
    }
        
}
      
