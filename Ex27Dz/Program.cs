// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе


double Main(int N)
    {
 
        double summa = 0;
        while (N / 10 >= 0)
        {
            summa = summa + N % 10;
           Console.WriteLine(summa); 

            N = N / 10;

        }
        
        return summa;
    }

int PrinNumber(string text)
{

    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());


}

int N = PrinNumber("vvedite chislo");

Main(N);