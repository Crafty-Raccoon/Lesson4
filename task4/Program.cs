// Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, но больше всех остальных).
// Постарайтесь сделать одним циклом
//[1, 3, 5, 6, 6, 4] -> 5

Random rnd = new Random();
int x = rnd.Next(5, 10);

int[] arr = new int[x];
for (int i = 0; i < x; i++)
{
    arr[i] = new Random().Next(-100, 100);
}

int max = arr[0];
int max2 = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max2 = max;
        max = arr[i];
    }
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}

Console.WriteLine();
Console.WriteLine($"Второе максимальное число массива = {max2}");