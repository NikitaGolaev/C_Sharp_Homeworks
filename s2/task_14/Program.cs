// Найти третью цифру числа или сообщить, что её нет

Console.Clear();

System.Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num / 100 == 0) System.Console.WriteLine("Третьей цифры в числе нет");

else
{
    while (num / 1000 != 0)
    {
        num = num / 10;
    }
    System.Console.WriteLine(num % 10);
}
