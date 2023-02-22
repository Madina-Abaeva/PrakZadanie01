// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
bool Num(int N)
{
    int tempNumber = N;
    int newNumber = 0;
    while (N > 0)
    {
        int remNumber = N % 10;
        N = N / 10;
    newNumber = newNumber * 10 + remNumber;

    }
     return  tempNumber==newNumber;
   


}
int Value(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int number = Value("vvedite chislo");


bool value = Num(number);
Console.WriteLine(value);
