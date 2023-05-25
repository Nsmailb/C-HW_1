// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int n = Input("Введите число N ");
int m = Input("Введите число M ");

int Input(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int Sum(int n, int m)
{
  if (n == m) return n;
  else return Sum(n + 1, m) + n;
}
Console.WriteLine(Sum(n, m));