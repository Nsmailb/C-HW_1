// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1,2,5,7,19 -> [1,2,5,7,19]

void FillArray(int[] collection)
{
int Length = collection.Length;
int index = 0;
while (index < Length)
     {
     collection[index] = new Random().Next(1, 8);
     index++;
     }
}

void PrintArray(int[] coll)
{
int Count = coll.Length;
int position = 0;
while (position < Count)
     {
     Console.WriteLine(coll[position]);
     position++;
     }
}
int[] array = new int[8];

FillArray(array);
PrintArray(array);