//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Ведите число A");
int nA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число B");
int nB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Возводим число A в натуальную степень числа B");
Console.WriteLine(Math.Pow(nA, nB)); 

// Но это ни какой не цикл выстроенный метод?
//int Pow(int nA, int nB)
// {
// int t = nA; //записываем промежуточный результат *=nA
// int Res2 = 0;
// for (int i=1; i<=nB; i++)
// {
//      t *=nA;
//      Res2 = t*nA;
//      i++;
// }
// return Res2;
// }
// Console.WriteLine(Pow(nA, nB)); // а вот это цикл но он не работает (24.04.2023)