/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

*/


int[,] Create2DArrayRandomInt(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i ++)
    {
        for (int j = 0; j < columns; j ++)
        {
            array[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
}

void Print2DArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0);i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
            if (j< array.GetLength(1)- 1)
            Console.Write(",");
        }
        if (i<array.GetLength(0)-1)
        Console.WriteLine(",");
        else Console.WriteLine(".");
    }
    Console.WriteLine();
}

/*
int [,]NewDecreasingArray(int [,]array)
{
    for (int i =0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        {
          for (int k = j +1; k < array.GetLength(0); k++)
          {
            if(array[i, k] > array[i, j] )
            {
                int temp = array[i, k];
                array[i, k] = array[i, j];
                array[i, j] = temp;
        }
        }
        }
    }
    return array;
}
*/

/*
int[,] newArray = Create2DArrayRandomInt(5,5,1,9);
Print2DArrayInt(newArray);
Console.WriteLine();
int[,] NewNewArray = NewDecreasingArray(newArray);
Print2DArrayInt(NewNewArray);
*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/


int[] SumNewArray(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
            sumArray[i] = sum;
        }
    }
    return sumArray;
}

int[,] myArray = Create2DArrayRandomInt(5,5,1,9);
Print2DArrayInt(myArray);
Console.WriteLine();

int[] sumArray = SumNewArray(myArray);

Console.WriteLine(sumArray);






/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

/*
int[,] CreateArray1(int rows, int columns, int minValue, int maxValue)
{
    int[,] array1 = new int[rows, columns];
    for (int i = 0; i < rows; i ++)
    {
        for (int j = 0; j < columns; j ++)
        {
            array1[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return array1;
}


int[,] CreateArray2(int rows, int columns, int minValue, int maxValue)
{
    int[,] array2 = new int[rows, columns];
    for (int n = 0; n < rows; n ++)
    {
        for (int m = 0; m < columns; m ++)
        {
            array2[n, m] = new Random().Next(minValue, maxValue+1);
        }
    }
    return array2;
}

*/


int[,] CreatNewArray(int[,] array1, int[,] array2)
{
    var newArray = new int [array1.GetLength(0), array2.GetLength(1)];
if (array1.GetLength(0) == array2.GetLength(1))
  {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                newArray[i, j] = 0;
                for (int k = 0; k < array2.GetLength(0); k++)
                {
                    newArray[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
        return newArray;
    }

   
else
{
    Console.WriteLine("Это не то. ");
    return null;
  }

}

int[,] myArray1 = Create2DArrayRandomInt(3,2,1,9);
Print2DArrayInt(myArray1);

int[,] myArray2 = Create2DArrayRandomInt(3,2,1,9);
Print2DArrayInt(myArray2);
Console.WriteLine();
int[,] resultArray = CreatNewArray(myArray1, myArray2);
Print2DArrayInt(resultArray);


/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

*/








/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

