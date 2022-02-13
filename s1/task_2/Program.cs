//Даны два числа. Показать большее и меньшее число

int num1 = new Random().Next(1, 100);
int num2 = new Random().Next(1, 100);

if (num1 > num2)
{
    System.Console.WriteLine($"num1: {num1}; num2: {num2};");
    System.Console.WriteLine("num1 больше num2");
}

else
{
    System.Console.WriteLine($"num1: {num1}; num2: {num2};");
    System.Console.WriteLine("num2 больше num1");
}
