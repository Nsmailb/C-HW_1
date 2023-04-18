// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату точки A по оси X");
int Xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки A по оси Y");
int Ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки A по оси Z");
int Za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси X");
int Xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси Y");
int Yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по оси Z");
int Zb = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((Xb-Xa),2)+Math.Pow((Yb-Ya),2)+Math.Pow((Zb-Za),2));
d=Math.Round(d,2);
Console.WriteLine(d);