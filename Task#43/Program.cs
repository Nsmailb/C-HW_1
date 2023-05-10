//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями -
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Пример: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите первую координату прямой A(k1)");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату прямой A(b1)");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первую координату прямой B(k2)");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату прямой B(b2)");
double b2 = Convert.ToInt32(Console.ReadLine());
double X = 0;
double Y = 0;
if (k1!=k2)
{
        X = (b2 - b1) / (k1 - k2);
        Y = k1 * X+ b1;
    Console.WriteLine("Координаты пересечения прямых по оси X"+" "+X); 
    Console.WriteLine("Координаты пересечения прямых по оси Y"+" "+Y);
}
else
{
    Console.WriteLine("Прямые не пересекаюся.");
}