// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
                        //Для цикла for
Console.WriteLine("Ведите цифру");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i<=num; i++)
{
    Console.WriteLine(Math.Pow(i,3));
}

                        //Для цикла while
                        // Console.WriteLine("Ведите цифру");
                        // int n = Convert.ToInt32(Console.ReadLine());
                        // int ii = 1;
                        // while (ii<=num)
                        // {
                        //     Console.WriteLine(Math.Pow(ii,3));
                        //     ii++;
                        // }