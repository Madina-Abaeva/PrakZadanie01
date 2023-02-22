// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubNumber(int value)
{
    
    for (int index = 1; index <= value; index++)
    {
     
       Console.WriteLine(" " + Math.Pow(index, 3)); 
        


    }                                                                               

}

int PrinNumber(string text)
{

    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());


}

int N = PrinNumber("vvedite chislo");
CubNumber(N);
 