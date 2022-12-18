using static MyLibrary;

// Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) 
// и выводит на экран десятичное представление числа, записанного в СС по основанию 15
// N: 3 [9, 4, 12] => 2097
public static class ArrayN
{
    public static void Main()
    {
        int size = Input("Сколько чисел в массиве: ");
        int[] ar = CreateArray(size);
        Fill(ar);
        Console.WriteLine(Print(ar));
        Console.WriteLine(MyLibrary.ConversionArray(ar));

    }
}