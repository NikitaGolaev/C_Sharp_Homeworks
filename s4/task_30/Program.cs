// Покажите кубы чисел, заканчивающихся на чётную цифру.

Console.Clear();

System.Console.Write("Введите положительное число: ");
int num = int.Parse(Console.ReadLine());

for (int i = 2; i <= num; i += 2) System.Console.WriteLine(i * i * i);
