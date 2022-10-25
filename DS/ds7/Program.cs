/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
double [,] CreateRandom2dArray()

{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double [rows, columns];
    Random rnd = new Random();

    for(int i = 0; i < rows; i ++)
    {
        for (int j = 0; j < columns; j ++)
                array[i,j] = Math.Round((rnd.Next(minValue, maxValue) + rnd.NextDouble()),1);
        }        return array;
    }


void Show2dArray(double[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

double[,]myArray = CreateRandom2dArray();
Show2dArray(myArray);

*/

/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение
 этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет

*/


/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int [,] CreateRandom2dArray()

{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int [rows, columns];

    for(int i = 0; i < rows; i ++)
    {
        for (int j = 0; j < columns; j ++)
                array[i,j] = new Random().Next(minValue, maxValue + 1);
        }        return array;
    }


void Show2dArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

int Average(int [,]array)
{
    int av = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0) && j=0; j < array.GetLength(1));
    sum = sum + array[i , j ];
}



int[,]myArray = CreateRandom2dArray();
Show2dArray(myArray);

//
int SumInHeadDiag(int[,]array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i ++)
    {
        sum = sum + array[i,i];
    }
    return sum;
    }
    int [,] myArray = CreateRandom2dArray();
    Show2dArray(myArray);
    int res = SumInHeadDiag(myArray);
    Console.WriteLine($"{res}");
