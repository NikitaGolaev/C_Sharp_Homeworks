// Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран.

Console.Clear();

void fillingMethod(int[] argument)
{
    int length = argument.Length;
    int i = 0;
    while (i < length)
    {
        argument[i] = new Random().Next(0, 2);
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

int[] array = new int[8];

fillingMethod(array);
printMethod(array);
