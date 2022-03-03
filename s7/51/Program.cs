// Задача 51: Задать двумерный массив следующим правилом: Aₘₙ = m+n.

Console.Clear();

int[,] arr = new int[3, 3];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = i + j;
        System.Console.Write($"{arr[i, j]} ");
    }
    System.Console.WriteLine();
}
