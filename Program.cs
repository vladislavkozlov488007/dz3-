System.Console.WriteLine("Введите координаты первой точки");
int x1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int x3 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координаты второй точки");
int y1 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int y3 = int.Parse(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow((x1-y1),2) + Math.Pow((x2-y2),2) + Math.Pow((x3-y3),2)),2);
System.Console.WriteLine($"Расстояние между первой и второй точкой равно {result}");