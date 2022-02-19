// Покажите кубы чисел, заканчивающихся на чётную цифру.

Console.Clear();

System.Console.Write("Введите положительное число: ");
int num = int.Parse(Console.ReadLine());

int count = 1;

while (count <= num)
{
    if (count * count * count % 2 == 0)
    {
        int i = count * count * count;
        System.Console.WriteLine($"Куб числа {count} из диапазона от 1 до {num} равен {i}, что является его чётным кубом");
        count++;
    }
    else count++;
}
