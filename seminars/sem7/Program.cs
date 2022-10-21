//Задача 1. Задайте двумерный массив размером m*n , заполненный случайными целыми числами.

/*
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

int[,]myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

//Задача 2. Задайте двумерный массив размера m*n , каждый элемент которого 
//находится по формуле Aij = i + j. Выведите на экран.
/*
int [,] Create2dArray()

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
                array[i,j] = i + j;
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

int[,]myArray = Create2dArray();
Show2dArray(myArray);

*/

//Задача 3. Задайте двумерный массив. Найдите элементы, у которых оба индекса четные и замените их на квадраты.
/*

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

void Quad2dArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j +=2)
        array[i,j] = array[i,j] * array[i,j]; 
                Console.WriteLine();
    }
}

int [,] myArray = CreateRandom2dArray();

Show2dArray(myArray);
Quad2dArray(myArray);
Show2dArray(myArray);

*/

//Задача 4. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0), (1,1) и т.д.)

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