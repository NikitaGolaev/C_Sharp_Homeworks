// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечётных/чётных чисел.

Console.Clear();

void fillingMethod(int[] argument)
{
    for (int i = 0; i < argument.Length; i++) argument[i] = new Random().Next(100, 1000);
}

void printMethod(int[] argument)
{
    for (int i = 0; i < argument.Length; i++) System.Console.Write($"{argument[i]} ");
    System.Console.WriteLine();
}

int[] arr = new int[10];

fillingMethod(arr);

printMethod(arr);

void evenOddMethod(int[] argument)
{
    int even = 0;
    int odd = 0;

    for (int i = 0; i < argument.Length; i++)
    {
        if (argument[i] % 2 == 0) even++;
        
        else odd++;
    }
    
    System.Console.WriteLine($"Чётных элементов массива: {even}");
    System.Console.WriteLine($"Нечётных элементов массива: {odd}");
}

evenOddMethod(arr);
