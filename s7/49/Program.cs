// Задача 49: Показать двумерный массив размером m×n, заполненный вещественными числами.

// Вопрос в 22 строке.

Console.Clear();

System.Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());

System.Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

double[,] twoArray = new double[m, n];

void FillingMethod(double[,] argument)
{
    for (int i = 0; i < argument.GetLength(0); i++)
    {
        for (int j = 0; j < argument.GetLength(1); j++)
        {
            // argument[i, j] = new Random().Next(1, 10);
            argument[i, j] = new Random().NextDouble() * 1000; // Получаются слишком сложные числа. Что можно с этим сделать?
        }
    }
}

void PrintMethod(double[,] argument)
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

FillingMethod(twoArray);
PrintMethod(twoArray);
