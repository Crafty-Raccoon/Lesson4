//Напишите программу, которая задаёт массив из 8 случайных элементов и выводит их на экран.

//1, 2, 5, 7, 19, 6, 7, 8

int[] arr = new int[8];
for (int i = 0; i < 8; i++)
{
    arr[i] = new Random().Next(0, 100);
}
Console.WriteLine();
for (int i = 0; i < 8; i++)
    Console.Write($"{arr[i]} ");
Console.WriteLine();