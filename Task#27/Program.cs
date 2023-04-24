//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.(452 -> 11)

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int Res = 0;

     while (num!=0)
     {
     Res = Res+ num %10;
     num = num/10; 
     } 
          
Console.WriteLine(Res);