
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

/*
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Create array: ");

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("/n Complete!");
    return array;
}

int PositivNum(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
int result = PositivNum(myArray);
ShowArray(myArray);
Console.WriteLine("Сумма чисел больше 0: " + result);
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
double[] Coordinate(double b1, double b2, double k1, double k2)

{
    double[] array = new double[2];
    array[0] = (b2 - b1) / (k1 - k2);
    array[1] = k1 * array[0] + b1;

    return array; ;
}


void ShowCoordin(double[] array)
{
    Console.Write($"[{array[0]};{array[1]}]");
}

Console.Write("b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] result = Coordinate(b1, b2, k1, k2);
ShowCoordin(result);

*/