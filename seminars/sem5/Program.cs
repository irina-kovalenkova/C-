//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка 
//[-9,9]. Найдите сумму отрицательных и положительных элементов массива.

int []CreateArray(int size)
{
    int[]array = new int [size];
    Console.WriteLine("Create array: ");

    for (int i = 0; i < size; i ++)
    {
        Console.Write($"Input a {i + 1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        }

    Console.WriteLine("/n Complete!");
    return array;
}

void ShowArray(int[]array)
{
    for (int i = 0; i < array.Length; i ++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

int SumOfNegatives(int[]array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i ++)
    {
        if (array[i] < 0)
        sum += array[i];
    }
    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
int result = SumOfNegatives(myArray);
ShowArray(myArray);
Console.WriteLine("Sum of a negative elements is" + result);









//То, то писал 5 зал
/*
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue);
    }
    return newArray;
}

/*Напишите программу замены элементов массива: положительные 
элементы замените на соответствующие отрицательные, и наоборот.*/

/*Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.*/

/*Задайте одномерный массив из 12 случайных чисел. Найдите 
количество элементов массива, значения которых лежат 
в отрезке [10,99].*/
/*
int[] ChangeArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1; 
    }
    return array;
}
Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size, minValue, maxValue);
ShowArray(myArray);
int[] myArray2 = ChangeArray(myArray);
ShowArray(myArray2);
*/
/*Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.*/
/*
bool Digit(int[] array, int number)
{
    for(int i = 0; i < array.Length; i++)
        if(array[i] == number)
            return true;
    return false;
}
Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] myNewArray = CreateArray( size,  minValue,  maxValue);
ShowArray(myNewArray);
bool digit = Digit(myNewArray, number);
Console.WriteLine(digit);
*/
/*Задайте одномерный массив из 12 случайных чисел. Найдите 
количество элементов массива, значения которых лежат 
в отрезке [10,99].*/

/*
int Summ(int[] array, int n, int m){
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] >= n && array[i] <= m)
        sum++;
    return sum;
}


Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] myNewArray = CreateArray( size,  minValue,  maxValue);
ShowArray(myNewArray);

int sum = Summ(myNewArray, n, m);

Console.WriteLine(sum);

*/


