/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

и

1 5 8 5

4 9 4 2

7 2 2 6

2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10

20 81 8 6

56 8 4 24

10 6 24 49*/

int[,] array1 =
{
    {3,2,5,8},
    {4,4,5,1},
    {6,2,1,6},
    {2,7,9,8}

};
int[,] array2 =
{
    {1,3,2,2},
    {3,2,5,1},
    {1,1,2,6},
    {7,1,2,6}

};

PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
PrintArray(MultArray(array1, array2));

int[,] MultArray(int[,] array, int[,] array2)
{
    int[,] multArray = new int[4, 4];


    for (int i = 0; i < array1.GetLength(1); i++)
    {
        for (int j = 0; j < array1.GetLength(0); j++)
        {

            multArray[i, j] = array1[i, j] * array2[i, j];

        }
    }

    return multArray;
}











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