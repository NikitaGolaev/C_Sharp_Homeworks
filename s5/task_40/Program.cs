// В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.

Console.Clear();

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

int[] arr = new int[10];

fillingMethod(arr);

printMethod(arr);

void minMaxDiff(int[] argument)
{
    int length = argument.Length;
    int i = 0;
    int max = argument[i];
    int min = argument[i];
    
    for (i = 0; i < length; i++)
    {
        if (argument[i] > max) max = argument[i];

        else if (argument[i] < min) min = argument[i];
    }

    System.Console.WriteLine($"Максимальный элемент: {max}");
    System.Console.WriteLine($"Минимальный элемент: {min}");
    System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {max - min}");
}

minMaxDiff(arr);
