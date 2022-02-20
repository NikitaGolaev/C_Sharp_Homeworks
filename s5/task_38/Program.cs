// Найти сумму чисел одномерного массива, стоящих на нечётной позиции.

Console.Clear();

int[] arr = new int[10];

void fillingMethod(int[] argument)
{
    int length = argument.Length;

    for (int i = 0; i < length; i++) argument[i] = new Random().Next(0, 100);
}

void printMethod(int[] argument)
{
    int length = argument.Length;

    for (int i = 0; i < length; i++) System.Console.Write($"{argument[i]} ");
    System.Console.WriteLine();
}

fillingMethod(arr);

printMethod(arr);

void oddMethod(int[] argument)
{
    int length = argument.Length;
    int sum = 0;

    for (int i = 0; i < length; i++)
    {
        if (argument[i] % 2 != 0) sum = argument[i] + sum;
    }
    
    System.Console.WriteLine($"Сумма нечётных чисел массива: {sum}");
}

oddMethod(arr);
