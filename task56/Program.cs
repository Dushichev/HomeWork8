/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
 которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт
 номер строки с наименьшей суммой элементов: 1 строка*/
int[,] array =
{
    {3,2,5,5},
    {4,5,5,1},
    {1,7,2,6},
    {1,4,3,33}

};
PrintArray(array);
Console.WriteLine();
int rowSum = 0;
int maxRowSum = 0;
int indexMaxRow = 0;
{

    for (int i = 0; i < array.GetLength(0); i++)
    {

        rowSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {

            rowSum += array[i, j];
        }

        if (rowSum > maxRowSum)
        {
            maxRowSum = rowSum;
            indexMaxRow = i;
        }
    }
}
Console.WriteLine("Максимальная сумма элементов = " + rowSum);

Console.WriteLine($" Номер строки c максимальной суммой элементов = {indexMaxRow}");




void PrintArray(int[,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write(array[i, j] + "\t");

        }
        Console.WriteLine();
    }
}
