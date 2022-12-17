﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Строки использовать нельззя

class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Введите число: ");                        //Вводим произвольное число
        int i = Convert.ToInt32(Console.ReadLine());
        int sum = 0;                                                //Присваиваем параметру сумма значение 0

        while (i > 0)                                               //цикл вычисление цифры и сложение цифр числа
        {
            int number = i % 10;
            i = i / 10;
            sum += number;
        }
        Console.WriteLine("Сумма всех цифр в числе равна " + sum);      //Вывод суммы цифр числа
    }
}


