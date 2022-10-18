//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (и в нулевую степень).
//Использовать свои функции, не использовать Math.Pow

//3, 5 -> 243 (3⁵)

//2, 4-> 16

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень");
int b = int.Parse(Console.ReadLine());

int c = a;
for (int i = 1; i < b; i++)
{
    c = (c * a);
}
Console.WriteLine($"{a} в степени {b} = {c}");