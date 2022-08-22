/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
 элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8*/


int[,] array =
{
    {3,2,5,8},
    {4,0,5,1},
    {1,1,2,6}

};


int[,] SortRow(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int s = 0; s < array.GetLength(1) - 1; s++)
            {
                if (array[i, s] > array[i, s + 1])
                {
                    int min = array[i, s + 1];
                    array[i, s + 1] = array[i, s];
                    array[i, s] = min;
                }
            }

        }
    }
    return array;
}

array = SortRow(array);

void PrintArray(int[,] array)
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

PrintArray(array);





