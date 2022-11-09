//Задача 1. Задайте двумерный массив. напишите программу, которая заменяет
//строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

void ChangeArray(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i <array.GetLength(0) - 1; i ++)
            for(int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }

    }
    else
    Console.WriteLine("It/s impussible!!!");
}

int[,] myArray = Create2DArrayRandomInt(5,5,1,9);
Print2DArrayInt(myArray);
ChangeArray(myArray);
Print2DArrayInt(myArray);
*/
//Задача 2. Задайте двумерный массив. Напишите программу, которая
//поменяет местами первую и последнюю строку массива


void RowsColumnsChangeArray(int[,] array)
 {
    for(int j = 0; j < array.GetLength(1); j++)
            {
                int temp = array[0,j];
                array[0,j] = array[array.GetLength(0) - 1, j];
                array[array.GetLength(0) -1, j] = temp;
            }
 }
int[,] myArray = Create2DArrayRandomInt(5,5,1,9);   
Print2DArrayInt(myArray); 
RowsColumnsChangeArray(myArray);
Print2DArrayInt(myArray);
  


//Задача 3. Из двумерного массива целых чисел удалить строку и столбец, 
//на пересечении которых расположен наименьший элемент.