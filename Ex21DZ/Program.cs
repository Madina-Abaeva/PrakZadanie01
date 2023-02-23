// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


        Console.WriteLine("Vvedite imy i koordinati tochki");
        string name = Console.ReadLine();
        int a1 = Convert.ToInt32(Console.ReadLine());
        int a2 = Convert.ToInt32(Console.ReadLine());
        int a3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("koordinat   {0}({1},{2},{3})", name, a1, a2, a3);
    Console.WriteLine("Vvedite imy i koordinati vtoroy tochki");
        string name2 = Console.ReadLine();
        int b1 = Convert.ToInt32(Console.ReadLine());
        int b2 = Convert.ToInt32(Console.ReadLine());
        int b3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("koordinat   {0}({1},{2},{3})", name2, b1, b2, b3);




  Console.WriteLine(Math.Sqrt( Math.Pow((b1-a1),2) +  Math.Pow((b2-a2),2) +   Math.Pow((b3-a3),2)  ) ) ;