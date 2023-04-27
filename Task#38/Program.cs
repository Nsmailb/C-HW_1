// ///Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// ///[3 7 22 2 78] -> 76

int[] numArr = new int [10];
int Diff = 0;

for (int i = 0; i < numArr.Length; i++)
{
    numArr[i] = new Random().Next(-10, 10);
}
Console.WriteLine("Массив чисел: "+String.Join(", ", numArr));

int Max = numArr[0];
int Min = numArr[0];

int GetMax()
{
   for (int i = 0; i < numArr.Length; i++)
    {
        if (numArr[i]>Max)
        {
           Max=numArr[i];
        }
    }
    return Max;
}
int ResMax = GetMax();
Console.WriteLine("Максимальное число ="+" "+ResMax);

int GetMin()
{
    for (int i = 0; i < numArr.Length; i++)
    {
        if (numArr[i] < Min)
        {
           Min=numArr[i];
        }
    }
    return Min;
}
int ResMin = GetMin();
Console.WriteLine("Минимальное число ="+" "+ResMin);
Console.WriteLine("Разница чисел: "+(Diff=Max-Min));