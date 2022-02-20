// Написать программу для замены элементов массива на противоположные.

Console.Clear();

void fillingMethod(int[] argument)
{
    int length = argument.Length;

    for (int i = 0; i < length; i++) argument[i] = new Random().Next(100, 1000);
}

void printMethod(int[] argument)
{
    int length = argument.Length;

    for (int i = 0; i < length; i++) System.Console.Write($"{argument[i]} ");
    System.Console.WriteLine();
}

void reverseNegativeArrayMethod(int[] argument)
{
    int length = argument.Length;

    for (int i = 0; i < length; i++) argument[i] = -argument[i];
}

int[] arr = new int[8];

fillingMethod(arr);

printMethod(arr);

reverseNegativeArrayMethod(arr);

printMethod(arr);
