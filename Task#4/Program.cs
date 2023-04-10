Console.WriteLine("Какое число из ваших чисел максимальное?");
Console.WriteLine("Ведите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if(number2 > number1) max = number2;
if(number3 > number2) max = number3;   

Console.Write("Максимальное число - ");
Console.WriteLine(max);
Console.Write("The End");