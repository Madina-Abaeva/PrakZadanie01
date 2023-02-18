// 8. Показать четные числа от 1 до N
Console.WriteLine("Vvedite n");
int n = int.Parse(Console.ReadLine());
int t = 1;

while (t < n)
{

    t = t + 1;

    if (t % 2 == 0)
    {
        Console.WriteLine("четные числа" + " " + t);
    }

}
