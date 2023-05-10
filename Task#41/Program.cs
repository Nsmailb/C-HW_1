//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
Console.WriteLine("Введите число <> 0");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число <> 0");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число <> 0");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число <> 0");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число <> 0");
int num5 = Convert.ToInt32(Console.ReadLine());

int[] Array = new int [5];
Array[0] = num1;
Array[1] = num2;
Array[2] = num3;
Array[3] = num4;
Array[4] = num5;
int MoreThenZero = 0;
Console.WriteLine("Вы ввели числа: "+String.Join(", ", Array));

for (int i=0; i<Array.Length; i++)
    {
    if ((Array[i] > 0))
    {
    MoreThenZero=MoreThenZero+1;
    }
    }
Console.WriteLine("Ровно "+MoreThenZero+""+" из них больше 0.");