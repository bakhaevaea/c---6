using System;

class MyNewClass
{

    public static void MyTask41()
    {
        // Пользователь вводит с клавиатуры M чисел.
        // Посчитайте, сколько чисел больше 0 ввёл пользователь.
        System.Console.WriteLine("Введите количество чисел");
        int count = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Введите чисела");

        int countPol = 0; 
        for (int i = 0; i < count; i++)
        {
            if (Convert.ToInt32(Console.ReadLine()) > 0)  countPol++;
        }
        System.Console.WriteLine($"Положительных чисел:  {countPol}");
    }

     static void MyTask43()
     {
        // Задача 43. Напишите программу, которая найдёт точку
        // пересечения двух прямых, заданных уравнениями y = k1 *
        // x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
        // пользователем.

        System.Console.WriteLine("Введите k1 ");
        int k1 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Введите b1 ");
        int b1 = Convert.ToInt32(Console.ReadLine());
        
        System.Console.WriteLine("Введите k2 ");
        int k2 = Convert.ToInt32(Console.ReadLine());
        
        System.Console.WriteLine("Введите b2 ");
        int b2 = Convert.ToInt32(Console.ReadLine());
        
        double x = Convert.ToDouble(b2-b1)/(k1-k2);
        double y = k1*x + b1;

        System.Console.WriteLine($"Точка пересечения имеет координаты ({Math.Round(x, 2)}; {Math.Round(y, 2)})");

     }

     static void Main()
    {
        MyTask43();
       
    }

}