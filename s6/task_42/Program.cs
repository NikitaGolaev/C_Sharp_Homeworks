// Определить, сколько чисел больше 0 введено с клавиатуры.

Console.Clear();

System.Console.Write("Введите положительное число: ");
string numInString = Console.ReadLine();
int length = numInString.Length;

int num = int.Parse(numInString);

if (num < 0) num = -(num);

int count = 0;

for (int i = 0; i <= length; i++) 
{
    if (num % 10 > 0) { count++; }

    num = num / 10;
}

System.Console.WriteLine($"Цифр больше 0: {count}");
