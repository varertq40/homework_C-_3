// Задача: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите x1 ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите y1 ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите z1 ");
int z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите x2 ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите y2 ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите z2 ");
int z2 = int.Parse(Console.ReadLine()!);

double c1 = Math.Pow((x2 - x1),2);
double c2 = Math.Pow((y2 - y1),2);
double c3 = Math.Pow((z2 - z2),2);
double c = Math.Sqrt(c1 + c2 + c3);
Console.WriteLine($"Расстояние от точки А до точки В состовляет {c}");