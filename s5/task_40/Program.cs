// В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.

Console.Clear();

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

int[] arr = new int[10];

fillingMethod(arr);

printMethod(arr);

void minMaxDiff(int[] argument)
{
    int length = argument.Length;
    int i = 0;    
    int max = argument[i];
    int min = argument[i];
    
    while (i < length)
    {
        if (argument[i] > max) max = argument[i];
        
        else if (argument[i] < min) min = argument[i];

        i++;
    }
    System.Console.WriteLine($"Максимальный элемент: {max}");
    System.Console.WriteLine($"Минимальный элемент: {min}");
    System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {max - min}");
}

minMaxDiff(arr);
