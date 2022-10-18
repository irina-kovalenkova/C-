//Задача 1. Напишите программу, которая перевернет одномерный массив
//(последний элемент будет на первом месте, а первый на последнем)


/*
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

int[]CreateRandomArray()
{
Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());


    int[]array = new int [size];
    for (int i = 0; i < size; i ++)
    {
    array[i] = new Random().Next(min, max +1);
    }
       return array;
}



int[] myArray = CreateRandomArray();
ShowArray(myArray);
*/

void ChangeNumber(int a)
{
    a += 5;
    Console.WriteLine(a);
}
int num = 5;
ChangeNumber(num);
Console.WriteLine(num);




