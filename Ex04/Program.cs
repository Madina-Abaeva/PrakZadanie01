﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Vvedite tri chisla");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int max;


if (a > b)
{


    if (a > c)
    {
        max = a;
        Console.WriteLine(max);
    }

}
else
{
    if (b > c)
    {
        max = b;

       Console.WriteLine(max);

    }
    else
    {
        max = c;
       Console.WriteLine(max);
    }

    
}


