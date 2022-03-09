// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем.

Console.Clear();

System.Console.Write("Введите первое число: ");
int sum = int.Parse(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

System.Console.Write("Введите количество шагов: ");
int N = int.Parse(Console.ReadLine());

int c = b;
int temp = sum;

System.Console.WriteLine();

int FibonacciMethod(int sum, int temp, int b, int N)
{
    System.Console.Write($"{temp} \t ");

    if (N > 0)
    {
        return FibonacciMethod(sum = temp + b, temp = b, b = sum, N - 1);
    }
    
    else { return -1; }
}

FibonacciMethod(sum, temp, b, N);
System.Console.WriteLine();

