// Написать программу масштабирования фигуры.

Console.Clear();

System.Console.Write("Введите количество точек, к которым применится коэффициент масштабирования: ");
int quantity = int.Parse(Console.ReadLine());
System.Console.Write("Введите коэффициент масштабирования: ");
int ratio = int.Parse(Console.ReadLine());

for (int i = 0; i < quantity; i++)
{
    System.Console.Write("Введите коодинату точки 'x': ");
    int x = int.Parse(Console.ReadLine());
    System.Console.Write("Введите коодинату точки 'y': ");
    int y = int.Parse(Console.ReadLine());
    System.Console.WriteLine($"x * k: {x * ratio}");
    System.Console.WriteLine($"y * k: {y * ratio}");
}
