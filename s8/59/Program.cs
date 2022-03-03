// Задача 59: В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.Clear();

int[,] arr = new int[3, 3];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(1, 10);
        System.Console.Write($"{arr[i, j]} ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

int sum = 0;
int max = 0;
int str = 0; // Индекс строки

for (int i = 0; i < arr.GetLength(0); i++)
{
    sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = arr[i, j] + sum;        
    }
    if (sum > max)
    {
        max = sum;
        str = i;
    }    
}

System.Console.WriteLine($"Индекс строки: {str}");
System.Console.WriteLine($"Сумма чисел строки: {max}");
