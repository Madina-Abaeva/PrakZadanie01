// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.




int number2Value(value)
{

    int number2 = value / 10 % 10;
    return number2;

}

Console.WriteLine(" Vvedite trexznachnoe chislo");
int value = int.Parse(Console.ReadLine());


if (value < 100 || value > 999)

{

    Console.WriteLine("vvedennoe chislo ne trexznachnoe");

}

  Console.WriteLine(number2Value(value));