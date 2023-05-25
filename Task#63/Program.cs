// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
// Выполнить с помощью рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"

Console.WriteLine("Ввeдите число");
int N = Convert.ToInt32(Console.ReadLine());

PrintNumbers(N);
void PrintNumbers(int N)
{
    if (N<1)
    {
        return;
    }
PrintNumbers(N-1);
Console.Write(N+" ");
}
