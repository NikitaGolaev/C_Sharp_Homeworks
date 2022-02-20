// Найти сумму чисел одномерного массива, стоящих на нечётной позиции.

Console.Clear();

int[] arr = new int[10];

void fillingMethod(int[] argument)
{
    int length = argument.Length;
    int i = 0;

    while (i < length)
    {
        argument[i] = new Random().Next(0, 100);
        i++;
    }
}

void printMethod(int[] argument)
{
    int length = argument.Length;
    int i = 0;

    while (i < length)
    {
        System.Console.Write($"{argument[i]} ");
        i++;
    }
    System.Console.WriteLine();
}

fillingMethod(arr);

printMethod(arr);

void oddMethod(int[] argument)
{
    int length = argument.Length;
    int i = 0;
    int sum = 0;

    while (i < length)
    {
        if (argument[i] % 2 != 0)
            sum = argument[i] + sum;
        i++;
    }
    System.Console.WriteLine($"Сумма нечётных чисел массива: {sum}");
}

oddMethod(arr);
