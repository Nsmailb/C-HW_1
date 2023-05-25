// Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
Console.WriteLine("Ввeдите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввeдите число N");
int N = Convert.ToInt32(Console.ReadLine());

if (M > N)
{
    Console.WriteLine("Введены не верные данные");
    return;
}
PrintNumbers(N, M);
void PrintNumbers(int N, int M)
{
    if (M>N)
    {
        return;
    }
Console.Write(M+" ");
PrintNumbers(N, M+1);
}
