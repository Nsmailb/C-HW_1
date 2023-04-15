// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Ведите цифру обозначающую день недели от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if ((number == 6)||(number == 7))
Console.WriteLine("Это выходной день недели");
else if (number > 7)
Console.WriteLine("Проверьте правильность введенноой цифры");
else if (number <= 0)
Console.WriteLine("Проверьте правильность введенноой цифры");
else
Console.WriteLine("Это рабочий день недели");