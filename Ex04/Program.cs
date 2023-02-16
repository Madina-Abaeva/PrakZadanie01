// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Vvedite tri chisla");
int a1 = int.Parse(Console.ReadLine());
int a2 = int.Parse(Console.ReadLine());
int a3 = int.Parse(Console.ReadLine());

int max;
max = a1;


if (max < a2)
{
    max = a2;

}

if (max < a3)
{
    max = a3;

}


Console.WriteLine(max);






