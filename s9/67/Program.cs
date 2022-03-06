// Задача 67: Показать натуральные числа от N до 1, N задано.
// N = 5. -> "5, 4, 3, 2, 1"

Console.Clear();

int n = 5;

int Recursion (int n)
{
    if (n == 0) return 0;
    System.Console.Write($"{n} ");
    return Recursion(n - 1);
}

Recursion(n);
