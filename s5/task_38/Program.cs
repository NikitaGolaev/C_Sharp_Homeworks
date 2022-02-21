// Найти сумму чисел одномерного массива, стоящих на нечётной позиции.

Console.Clear();

int[] arr = new int[10];

void fillingMethod(int[] argument)
{
    for (int i = 0; i < argument.Length; i++) argument[i] = new Random().Next(0, 100);
}

void printMethod(int[] argument)
{
    for (int i = 0; i < argument.Length; i++) System.Console.Write($"{argument[i]} ");
    System.Console.WriteLine();
}

fillingMethod(arr);

printMethod(arr);

void oddMethod(int[] argument)
{
    int sum = 0;

    for (int i = 0; i < argument.Length; i++)
    {
        if (argument[i] % 2 != 0) sum = argument[i] + sum;
    }
    
    System.Console.WriteLine($"Сумма нечётных чисел массива: {sum}");
}

oddMethod(arr);
