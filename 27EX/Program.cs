// See https://aka.ms/new-console-template for more information

int SumNumbers(int N)
{
    int len = Convert.ToString(N).Length;
    int summa = 0;
    for (int i = 0; i < len; i++)
    {
        while (N >= 0)
        {
            summa = summa + N % 10;
            N = N / 10;
        }

    }
return summa;
}

int PrinNumber(string text)
{

    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());


}

int N = PrinNumber("vvedite chislo");
 SumNumbers(N);
Console.WriteLine(N);

