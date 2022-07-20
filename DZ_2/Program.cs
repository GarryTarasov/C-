// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


Console.WriteLine("Введите число (А)");
int number_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число (B)");
int number_B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число (C)");
int number_C = Convert.ToInt32(Console.ReadLine());
int max=0;

if (number_A >= number_B&&number_A>=number_C)
{
    max=number_A;
}
else if(number_B>=number_C&&number_B>=number_A)
{
    max=number_B;
}
else if(number_C>=number_A&&number_C>=number_B)
{
    max=number_C;
}
    {
    Console.WriteLine("наибольшее число среди трёх "+ max);
    }




    
        
    
      
