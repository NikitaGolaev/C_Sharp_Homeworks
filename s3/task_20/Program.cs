// Задать номер четверти, показать диапазоны для возможных координат

Console.Clear();

System.Console.Write("Введите номер четверти системы координат: ");
int n = int.Parse(Console.ReadLine());

if (n == 1) System.Console.WriteLine("Первая четверть. Диапазон возможных координат: x >= 0, y >= 0");
else if (n == 2) System.Console.WriteLine("Вторая четверть. Диапазон возможных координат: x < 0, y >= 0");
else if (n == 3) System.Console.WriteLine("Третья четверть. Диапазон возможных координат: x < 0, y < 0");
else if (n == 4) System.Console.WriteLine("Четвёртая четверть. Диапазон возможных координат: x >= 0, y < 0");
else System.Console.WriteLine("Введено не верное число");
