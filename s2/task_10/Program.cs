// Показать вторую цифру трёхзначного числа

Console.Clear();

System.Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());

int num2 = num / 10;

System.Console.WriteLine(num2 % 10);
