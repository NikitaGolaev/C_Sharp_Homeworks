// Найти кубы чисел от 1 до N

Console.Clear();

System.Console.WriteLine("Введите число большее 1: ");
int m = int.Parse(Console.ReadLine());

int i = 1;
while (i <= m)
{
    System.Console.Write($"{i*i*i} ");
    i++;
}
