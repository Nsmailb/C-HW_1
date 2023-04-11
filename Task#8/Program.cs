Console.WriteLine("При вводе числе показываю все четные от 1 до введенного");
Console.WriteLine("Ведите число");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;

while(i <= number)
    {
    if((i % 2) == 0)    
        {
            Console.WriteLine(i);
            i=i+i;
        }
   Console.WriteLine(i++);
   }
Console.Write("The End");