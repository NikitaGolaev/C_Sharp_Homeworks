// Задача 69: Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N.
// M = 1; N = 4 -> 10
// M = 4; N = 8. -> 30

Console.Clear();

// Проверки на неправильный ввод не делал.
System.Console.Write("Введите два числа через пробел: ");
string[] str = Console.ReadLine().Split(' ');

int firstLimit = 0;
int secondLimit = 0;

for (int i = 0; i < str.Length; i++)
{
    if (i == 0) { firstLimit = int.Parse(str[i]); }
    else if (i == 1) { secondLimit = int.Parse(str[i]); }
}

int sum = 0;

void Recursion(int firstLimit) // Обязательно отдавать 2 элемента, если и так работает?
{
    sum += firstLimit;
    System.Console.Write($"{firstLimit} ");

    if (firstLimit == secondLimit) { return; }

    else if (firstLimit > secondLimit) { Recursion(firstLimit - 1); }

    else { Recursion(firstLimit + 1); }
}

Recursion(firstLimit);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов последовательности: {sum}");
