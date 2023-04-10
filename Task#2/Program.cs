Console.WriteLine("Какое число больше - первое или второе?");
Console.WriteLine("Ведите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 >= number2)
{
Console.WriteLine("Первое число больше второго (или равно ему, если вы ввели одинаковые числа)!");
}
else 
{
Console.WriteLine("Первое число меньше второго второго!");
}
Console.Write("The End");