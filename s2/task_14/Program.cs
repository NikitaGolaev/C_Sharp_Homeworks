// Найти третью цифру числа или сообщить, что её нет

Console.Clear();

System.Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num / 100 != 0)
{
    int num2 = num / 100; // num2 хранит целый остаток от деления на 100

    if (num2 / 10 != 0) System.Console.WriteLine($"Третья цифра в числе: {num2 % 10}");
    else System.Console.WriteLine($"Третья цифра в числе: {num2}");
}
else System.Console.WriteLine("Третьей цифры в числе нет");
