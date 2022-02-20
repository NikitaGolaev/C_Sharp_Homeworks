// Написать программу для замены элементов массива на противоположные.

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

void reverseNegativeArrayMethod(int[] argument)
{
    int length = argument.Length;
    int i = 0;

    while (i < length)
    {
        argument[i] = -argument[i];
        //System.Console.Write($"{argument[i]} ");
        i++;
    }
}

//int[] arr = { 1, 4, 9, 8, 3 };
int[] arr2 = new int[8];

fillingMethod(arr2);

printMethod(arr2);

reverseNegativeArrayMethod(arr2);

printMethod(arr2);
