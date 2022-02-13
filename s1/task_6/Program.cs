// Выяснить является ли число чётным

Console.Clear();

//int num = int.Parse(Console.ReadLine());
int num = new Random().Next(1, 100);

System.Console.WriteLine(num);

if (num % 2 == 0) System.Console.WriteLine("Число чётное");
// {
//     System.Console.WriteLine("Число чётное");
// }

else
{
    System.Console.WriteLine("Число нечётное");
}
