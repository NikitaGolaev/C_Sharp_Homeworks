// Задача 61: Найти произведение двух матриц.

Console.Clear();

int sizeLong = 3;
int sizeShort = 2;

int[,] aMatrix = new int[sizeLong, sizeShort];
int[,] bMatrix = new int[sizeShort, sizeLong];
int[,] product = new int[sizeLong, sizeLong];

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

FillingMethod(aMatrix);
FillingMethod(bMatrix);

PrintMethod(aMatrix);
System.Console.WriteLine();
PrintMethod(bMatrix);
System.Console.WriteLine();

for (int row = 0; row < sizeLong; row++)
{    
    for (int col = 0; col < sizeLong; col++)
    {        
        for (int inner = 0; inner < sizeShort; inner++)
        {
            product[row, col] += aMatrix[row, inner] * bMatrix[inner, col];
        }
        System.Console.Write(product[row, col] + "\t");
    }
    System.Console.WriteLine();
}
