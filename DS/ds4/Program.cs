/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

//Решение:
/*
Console.Clear();
double Cub(double A, double B)
{
    return Math.Pow(A,B);
    }
Console.Write("Input A: ");
double A = Convert.ToDouble(Console.ReadLine());

Console.Write("Input B: ");
double B = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Cub(A,B));

*/

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
//Решение:
/*
Console.Clear();
int SumOfDigits(int num) 
{
    int res = 0;
    if (num < 0) num *= -1;

    while (num > 0)
    {
        res += num % 10;
        num /= 10;
    }

    return res;
}
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"The sum of the digits of the number {number} is {SumOfDigits(number)}.");

*/

/*
Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

m = 5 -> [1, 2, 5, 7, 19]

m = 3 -> [6, 1, 33]
*/
//Решение:
/*
Console.Clear();
int []CreateRandomArray(int size, int minValue, int maxValue)
{
    int[]newArray = new int[size];
    for (int i = 0; i < size; i ++)
    newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void ShowArray(int[]array)
{
    for(int i = 0; i < array.Length; i ++)

Console.Write(array[i] + " ");
Console.WriteLine();
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min of elements: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[]myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

*/

//Задача дополнительная

//Решение:


