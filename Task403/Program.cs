// Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) 
// и выводит на экран десятичное представление числа, записанного в СС по основанию 15
// N: 3 [9, 4, 12] => 2097

int n = 10;
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"{i}³ = {i*i*i}");
}
//Console.WriteLine(MyLibrary.Pow(2, 10));
Console.WriteLine(MyLibrary.ToDec(new int[] { 9, 4, 12 }));