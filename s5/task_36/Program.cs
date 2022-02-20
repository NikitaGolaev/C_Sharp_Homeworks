// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечётных/чётных чисел.

Console.Clear();

void fillingMethod(int[] argument)
{
    int length = argument.Length;
    int i = 0;

    while (i < length)
    {
        argument[i] = new Random().Next(100, 1000);
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

int[] arr = new int[10];

fillingMethod(arr);

printMethod(arr);

void evenOddMethod(int[] argument)
{
    int length = argument.Length;
    int i = 0;
    int i1 = 0;
    int i2 = 0;

    while (i < length)
    {
        if (argument[i] % 2 == 0) i1++;

        else i2++;
        
        i++;
    }
    System.Console.WriteLine($"Чётных: {i1}");
    System.Console.WriteLine($"Нечётных: {i2}");
}

evenOddMethod(arr);
