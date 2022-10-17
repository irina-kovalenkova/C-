/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/


/*
Console.Clear();
int[]CreateRandomArray(int size, int minValue, int maxValue)
{
    int[]newArray = new int [size];
    for (int i = 0; i < size; i ++)
    {
    newArray[i] = new Random().Next(minValue, maxValue +1);
    }
       return newArray;
}

void ShowArray(int[]array)
{
    for (int i = 0; i < array.Length; i ++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

int EvenArray(int[]array)
{
       int sum = 0;

       for (int i = 0; i < array.Length; i ++)
       {
            if (array[i] % 2 == 0)
            sum ++;
       }
                 return sum;
                 }

Console.WriteLine("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min number in the array: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max number in the array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size, minValue, maxValue);
ShowArray(myArray);
Console.WriteLine($"The number of even numbers in the array: {EvenArray(myArray)}");
*/



/*
Задача 36: Задайте одномерный массив, заполненный случайными 
числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

/*
Console.Clear();
int[]CreateRandomArray(int size, int minValue, int maxValue)
{
    int[]newArray = new int [size];
    for (int i = 0; i < size; i ++)
    {
    newArray[i] = new Random().Next(minValue, maxValue +1);
    }
       return newArray;
}

void ShowArray(int[]array)
{
    for (int i = 0; i < array.Length; i ++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

int EvenArray(int[]array)
{
       int sum = 0;

       for (int i = 0; i < array.Length; i += 2)
       {
            sum += array[i];
            sum ++;
       }
                 return sum;
                 }
  
Console.WriteLine("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min number in the array: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max number in the array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size, minValue, maxValue);
ShowArray(myArray);

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {EvenArray(myArray)}");

*/

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
/*
Console.Clear();
int []CreateRandomArray(int size, int minValue, int maxValue)
{
    int[]newArray = new int [size];
    for (int i = 0; i < size; i ++)
    {
    newArray[i] = new Random().Next(minValue, maxValue +1);
    }
       return newArray;
}

void ShowArray(int[]array)
{
    for (int i = 0; i < array.Length; i ++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

int MinMaxElement(int[]array)
{
    int minNum = array[0];
    for(int i = 0; i < array.Length; i ++)
    {
        if (array[i] < minNum) 
        minNum = array[i];
           }
    
    int maxNum = array[0];
    for(int i = 0; i < array.Length; i ++)
    {
        if (array[i] > maxNum) 
        maxNum = array[i];
           }
    return maxNum - minNum;

}

Console.WriteLine("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min number in the array: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max number in the array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());


int [] myArray = CreateRandomArray(size, minValue, maxValue);
ShowArray(myArray);
Console.WriteLine($"The difference between the maximum and minimum element is: {MinMaxElement(myArray)}");

*/