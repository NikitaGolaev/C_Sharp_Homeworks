// Подсчитайте сумму цифр в числе.

Console.Clear();

System.Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int i = 1;
int numDuplicate = num;

while (num > 10)
{
    i++;
    //System.Console.Write($"{i} ");
    num = num / 10;    
}

int sum = 0;
num = numDuplicate;

while (i != 0)
{
    sum = num % 10 + sum;
    num = num / 10;
    i--;    
}
System.Console.WriteLine($"Сумма цифр в числе {numDuplicate} равна: {sum}");
