// Задача 53: В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.

Console.Clear();

int[,] array = new int[3, 3];

void FillingMethod(int[,] argument)
{
    for (int i = 0; i < argument.GetLength(0); i++)
    {
        for (int j = 0; j < argument.GetLength(1); j++)
        {
            argument[i, j] = new Random().Next(1, 10);            
        }
    }
}

void PrintMethod(int[,] argument)
{
    for (int i = 0; i < argument.GetLength(0); i++)
    {
        for (int j = 0; j < argument.GetLength(1); j++)
        {
            System.Console.Write($"{argument[i, j]} ");
        }

        System.Console.WriteLine();
    }
}

FillingMethod(array);

PrintMethod(array);
System.Console.WriteLine();

int find = 4; // Ищем число 4
int count = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {       
        if (array[i, j] == 4)
        {
            System.Console.WriteLine($"{i} {j}");
            count++;
        }
    }
}
if (count == 0) { System.Console.WriteLine("Число отсутствует."); }
