
// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень ,нельзя использовать Math.Pow



int Main(int number1, int number2)

{
    int number = number1;
    int ext = number2;
    int stepen = 1;
    int index = 1;
    while (index <= ext)
    {

        stepen = stepen * number;
        index++;
       
    }

    return stepen;
}

int Value(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}




int number1 = Value("vvedite chislo");
int number2 = Value("vvedite stepen'");
int ExtNumber = Main(number1, number2);
Console.WriteLine($"{ number1} v  { number2} stepeni = " + ExtNumber );




