// Задача 57: Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

Console.Clear();

int[,] arr = new int[3, 10];

void FillMethod(int[,] argument)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 21);
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void PrintMethod(int[,] argument)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

FillMethod(arr);
PrintMethod(arr);
System.Console.WriteLine();

for (int k = 0; k < arr.GetLength(0); k++)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = arr.GetLength(1) - 1; j > 0; j--)
        {
            if (arr[k, j] > arr[k, j - 1])
            {
                int reserve = arr[k, j - 1];
                arr[k, j - 1] = arr[k, j];
                arr[k, j] = reserve;
            }
        }
    }
}

PrintMethod(arr);
