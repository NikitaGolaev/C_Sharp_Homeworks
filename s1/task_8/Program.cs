// Показать четные числа от 1 до N

Console.Clear();

int n = 1;

Console.Write("Введите число большее 1: ");
int m = int.Parse(Console.ReadLine());

System.Console.WriteLine();
System.Console.WriteLine($"Все чётные числа из диапазона от 1 до {m} включительно: ");

for (int i = 2; i <= m; i += 2) Console.Write($"{i} ");
