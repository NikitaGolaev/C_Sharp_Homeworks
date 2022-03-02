// Задача 55: Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.Clear();

System.Console.Write("Количество строк массива: ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("Количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

int[,] arr = new int[m, n];

void FillingMethod(int[,] argument)
{
    for (int i = 0; i < argument.GetLength(0); i++)
    {
        for (int j = 0; j < argument.GetLength(1); j++)
        {
            argument[i, j] = new Random().Next(1, 10);
        }
    }
}

FillingMethod(arr);

void PrintMethod(int[,] argument)
{
    for (int i = 0; i < argument.GetLength(0); i++)
    {
        for (int j = 0; j < argument.GetLength(1); j++)
        {
            System.Console.Write($"{argument[i, j]} ");
        }

        System.Console.WriteLine();
    }
}

PrintMethod(arr);
System.Console.WriteLine();

System.Console.WriteLine("Среднее арифметическое столбцов массива: ");
for (int j = 0; j < arr.GetLength(1); j++)
{    
    System.Console.WriteLine((j + 1) + " - " + ((double) (arr[0, j] + arr[1, j] + arr[2, j]) / m)); // 'm' - количество строк массива.
}
