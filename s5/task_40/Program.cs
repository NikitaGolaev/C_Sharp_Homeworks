// В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.

Console.Clear();

void fillingMethod(int[] argument)
{
    for (int i = 0; i < argument.Length; i++) argument[i] = new Random().Next(0, 100);
}

void printMethod(int[] argument)
{
    for (int i = 0; i < argument.Length; i++) System.Console.Write($"{argument[i]} ");
    System.Console.WriteLine();
}

int[] arr = new int[10];

fillingMethod(arr);

printMethod(arr);

void minMaxDiff(int[] argument)
{
    int i = 0;
    int max = argument[i];
    int min = argument[i];
    
    for (i = 0; i < argument.Length; i++)
    {
        if (argument[i] > max) max = argument[i];

        else if (argument[i] < min) min = argument[i];
    }

    System.Console.WriteLine($"Максимальный элемент массива: {max}");
    System.Console.WriteLine($"Минимальный элемент массива: {min}");
    System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {max - min}");
}

minMaxDiff(arr);
