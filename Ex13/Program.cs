// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number3Value(int value)
{
    int number3 = value % 10;
    return number3;
}

Console.WriteLine("Vvedite trexznachnoe chislo ");
int value = int.Parse(Console.ReadLine());

if (value < 100)
{
    Console.WriteLine("tret'ey cifri net ");
    return;

}

Console.WriteLine(number3Value(value));

