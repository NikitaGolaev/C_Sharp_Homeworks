// Возведите число А в натуральную степень B, используя цикл.

Console.Clear();

System.Console.Write("Введите число 'A': ");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Введите число 'B', которое будет степенью числа 'A': ");
int b = int.Parse(Console.ReadLine());

int a2 = a;

for (int i = 1; i < b; i++) { a2 = a2 * a; }
System.Console.WriteLine($"Число {a} в степени {b} равно: {a2}.");
