// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ Math.Pow


class Exponentiation
{
    static void Main(string[] args)
    {
        Console.Write("Введите число A - ");                //Вводим число А
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число B - ");                //Вводим число В
        int b = Convert.ToInt32(Console.ReadLine());
        int j = a;                                              //Присваиваем новой переменной значение "A"


        for (int count = 1; count < b; count++)                 //Цикл для возведения степени
        {
            j *= a;
        }
        Console.WriteLine("A ^ В = " + j);           //Выводим результат
    }
}




