// Написать программу для замены элементов массива на противоположные.

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

void reverseNegativeArrayMethod(int[] argument)
{
    for (int i = 0; i < argument.Length; i++) argument[i] = -argument[i];
}

int[] arr = new int[8];

fillingMethod(arr);

printMethod(arr);

reverseNegativeArrayMethod(arr);

printMethod(arr);
