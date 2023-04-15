// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Ведите число");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString(Console.ReadLine());
if (number > 100)
        {
        Console.WriteLine("3 цифра - " +str[2]);
        }
else
        {
        Console.WriteLine("Третьей цифры нет");
        }