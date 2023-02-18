// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Vvedine chislo");
int day = int.Parse(Console.ReadLine());

if ((day >= 1 && day <= 7))
{

    if ((day >= 1 && day <= 5))
    {

        Console.WriteLine(" Rabochiy den' ");
    }

    else
    {

        Console.WriteLine("Vixodnoy den'");


    }



}
else
{

    Console.WriteLine(" Vvedite chislo ot 1 do 7 ");


}



