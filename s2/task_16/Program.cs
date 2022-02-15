// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Clear();

System.Console.Write("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine());

if (num < 1 | num > 7) System.Console.WriteLine("Число задано не верно");
else
{
    if (num >= 1 & num <= 5) System.Console.WriteLine("Не выходной");
    else if (num >= 6 & num <= 7) System.Console.WriteLine("Выходной");
}


// ---------------------------------------------------------------------------
//Второй способ
// Console.Clear();

// System.Console.Write("Введите число от 1 до 7: ");
// int num = int.Parse(Console.ReadLine());

// if (num == 1) System.Console.WriteLine("Не выходной");
// else if (num == 2) System.Console.WriteLine("Не выходной");
// else if (num == 3) System.Console.WriteLine("Не выходной");
// else if (num == 4) System.Console.WriteLine("Не выходной");
// else if (num == 5) System.Console.WriteLine("Не выходной");
// else if (num == 6) System.Console.WriteLine("Выходной");
// else if (num == 7) System.Console.WriteLine("Выходной");
// else System.Console.WriteLine("Число задано не верно");


// ---------------------------------------------------------------------------
// Третий способ через массив. Не докрутил пока что.
// Console.Clear();

// string[] arr = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
// int[] arr2 = { 1, 2, 3, 4, 5, 6, 7 };

// System.Console.Write("Введите число от 1 до 7: ");
// int num = int.Parse(Console.ReadLine());

// if (num < 1 | num > 7) System.Console.WriteLine("Число задано не верно");
// else
// {
//     int i = 0;
//     while (arr2[i] != num) i++;
//     System.Console.WriteLine(arr[i]);
// }
