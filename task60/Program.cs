/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)*/


int[,,] array = new int[3, 3, 3];
Random random = new Random();





for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {

            array[i, j, k] = random.Next(10, 99);
            int x = array[i, j, k];
            int y = 0;
            if (y == x)
                break;
            if (y != x)
                x = y;
        }
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine("лист номер " + (i + 1));

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.Write(array[i, j, k] + " : ");
            Console.Write((i, j, k) + " || ");
        }
        Console.WriteLine();
    }

}

