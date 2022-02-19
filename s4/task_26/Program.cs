// Возведите число А в натуральную степень B, используя цикл.

Console.Clear();

System.Console.WriteLine("Введите число 'A': ");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число 'B', которое будет степенью числа 'A': ");
int b = int.Parse(Console.ReadLine());

int num = a;

for (int count = 1; count < b; count++) a = a * num;
System.Console.WriteLine(a);


// ---------------------------------------------------------------------------------->
// int count = 1;

// while (count < b)
// {
//     a = a * num;
//     count++;
// }

// System.Console.WriteLine(a);
