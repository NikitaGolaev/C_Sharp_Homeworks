// Удалить вторую цифру трёхзначного числа

Console.Clear();

System.Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());

if (num / 100 == 0) System.Console.WriteLine("Число задано не верно!");

else if (num / 1000 != 0) System.Console.WriteLine("Число задано не верно!");

else
{
    int num2 = num / 100; // Первая цифра
    int num3 = num % 10; // Последняя цифра

    System.Console.WriteLine($"{num2}{num3}");
}
