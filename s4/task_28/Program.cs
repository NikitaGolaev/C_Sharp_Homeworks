// Подсчитайте сумму цифр в числе.

Console.Clear();

System.Console.Write("Введите число: ");
string num = Console.ReadLine();

int length = num.Length;
int copyNum = int.Parse(num);
int sum = 0;

for (int i = 0; i < length; i++)
{
    sum = sum + (copyNum % 10);
    copyNum = copyNum / 10;
}

System.Console.WriteLine($"Сумма цифр в числе: {sum}");
