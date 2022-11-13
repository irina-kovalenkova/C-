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

/*
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
/*
int[] SumNewArray(int[,] array)
{
    int[] sumArray = new int[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
            sumArray[j] = sum;
        }
    }
    return sumArray;
   }

int[,] myArray = Create2DArrayRandomInt(4,4,1,9);
Print2DArrayInt(myArray);
Console.WriteLine();

int IndexMinElements(int[] array)
{
    int iMin = 0;
    int min = array[iMin];
    for (int i = 1; i < array.Length - 1; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            iMin = i;
        }
    }
    return iMin;
}
int[] sumArray = SumNewArray(myArray);
int numbRows = (IndexMinElements(sumArray) + 1);
Console.WriteLine($"Номер строки с наименьшей суммой элементов : {numbRows}");

*/

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
    Console.WriteLine("Alarm! Количество строк в первой матрице должно совпадать с количеством столбцов во второй. Срочно исправьте!");
    return newArray;
}
}

int[,] myArray1 = Create2DArrayRandomInt(2,2,1,9);
Print2DArrayInt(myArray1);

int[,] myArray2 = Create2DArrayRandomInt(2,2,1,9);
Print2DArrayInt(myArray2);
Console.WriteLine();
int[,] resultArray = CreatNewArray(myArray1, myArray2);
Print2DArrayInt(resultArray);

*/

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

/*
int[,] ArraySpiral(int rows, int columns)
{
        int[,] array = new int[rows, columns];

    for (int operation = 0, current = 1; current <= rows * columns; operation++)
    {
        for (int i = operation, j = operation; j < columns - operation; j++, current++) 
            array[i, j] = current;

        if (current > rows * columns) break;
        for (int i = operation + 1, j = columns - operation - 1; i < rows - operation; i++, current++) 
            array[i, j] = current;

        if (current > rows * columns) break;
        for (int i = rows - operation - 1, j = columns - operation - 2; j >= operation; j--, current++) 
            array[i, j] = current;

        if (current > rows * columns) break;
        for (int i = rows - operation - 2, j = 0 + operation; i >= operation + 1; i--, current++) 
            array[i, j] = current;
    }
    return array;
}

void PrintSpiral(int[,] array, int zeroNum = 2)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j].ToString($"D{zeroNum}") + " "); 
        Console.WriteLine();
}
}

int[,] spiralarr = ArraySpiral(5, 5);
    PrintSpiral(spiralarr);

   */ 