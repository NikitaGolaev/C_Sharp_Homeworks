// Найти максимальное из трех чисел

int num1 = new Random().Next(1, 100);
int num2 = new Random().Next(1, 100);
int num3 = new Random().Next(1, 100);

int max = num1;

System.Console.WriteLine($"{num1} {num2} {num3}");

if (max < num2)
{
    max = num2;
}

else if (max < num3)
{
    max = num3;
}

System.Console.WriteLine(max);
