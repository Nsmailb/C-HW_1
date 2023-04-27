//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
///[345, 897, 568, 234] -> 2
int[] numArr = new int [10];
int EvenNum = 0;

for (int i=0; i<numArr.Length; i++)
    {
    numArr[i] = new Random().Next(100, 1000);
    if ((numArr[i] % 2) == 0)
    {
    EvenNum=EvenNum+1;
    }
}
Console.WriteLine("Массив трехзначных чисел: \n"+String.Join(", ", numArr)+ "\nСодержит"+" "+EvenNum+" "+"четных.");