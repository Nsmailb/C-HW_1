Console.WriteLine("Является ли ваше число четным?");
Console.WriteLine("Ведите число");
int number = Convert.ToInt32(Console.ReadLine());
if((number % 2) == 0)
Console.WriteLine("Ваше число четное!");
else
{
Console.WriteLine("Ваше число не четное!");
}
Console.Write("The End");