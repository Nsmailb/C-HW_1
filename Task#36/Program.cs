//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
///[3, 7, 23, 12] -> 19 
///[-4, -6, 89, 6] -> 0

int[] numArr = new int [10];
int SumNotEvenPos = 0;

for (int i=0; i<numArr.Length; i++)
    {
    numArr[i] = new Random().Next(0, 10);
    if ((i % 2) != 0)
    {
    SumNotEvenPos+=numArr[i];
    }
}    
Console.WriteLine("Массив чисел: "+String.Join(", ", numArr));
Console.WriteLine("Сумма чисел массива на нечетных позициях (i) ="+" "+SumNotEvenPos);