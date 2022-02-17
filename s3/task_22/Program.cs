// Найти расстояние между точками в пространстве 2D/3D

Console.Clear();

System.Console.WriteLine("Задайте координаты точки 'A' в трёхмерном пространстве:");
System.Console.Write("x1: ");
double Ax = double.Parse(Console.ReadLine());
System.Console.Write("y1: ");
double Ay = double.Parse(Console.ReadLine());
System.Console.Write("z1: ");
double Az = double.Parse(Console.ReadLine());
System.Console.WriteLine("Задайте координаты точки 'B' в трёхмерном пространстве:");
System.Console.Write("x1: ");
double Bx = double.Parse(Console.ReadLine());
System.Console.Write("y1: ");
double By = double.Parse(Console.ReadLine());
System.Console.Write("z1: ");
double Bz = double.Parse(Console.ReadLine());

System.Console.Write($"Расстояние между точками A и B: ");
double result2 = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2)); 
System.Console.WriteLine(result2);
