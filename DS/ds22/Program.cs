/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

//Решение:
/*
int SecondDigitNumber(int num)
{
    int result;
    int ed = num % 100;
    int dec = ed / 10;
    result = dec;
    return result;
}
Console.Write("Enter a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigitNumber = SecondDigitNumber(number);
Console.WriteLine("The number in the middle :" + secondDigitNumber);
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
//Решение:

/*
string TreeDigitNumber(int num)
{
    string result;
    string numberDigit = Convert.ToString(num);
    if (numberDigit.Length < 3)
        result = "There is no third digit";
    else
    {
        char thirdDigit = numberDigit[2];
        result = $"The third digit is {thirdDigit}";
    }
    
    return result;
}
Console.Write("Input number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
string treeDigitNumber = TreeDigitNumber(number1);
Console.WriteLine(treeDigitNumber);
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
/*
bool WeekendNumber (int num)
{
bool result;
if(num == 1 || num == 2 || num == 3 || num == 4 || num ==5)
{
    result = false;
}
else
{
    result = true;
}
return result;
}
Console.Write("Enter the number of the day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());
bool weekendNumber = WeekendNumber(num);
if (weekendNumber)
Console.WriteLine("Today is a day off");
else
Console.WriteLine("Today is a working day");

*/

//21.10
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

/*
void ShowArray(int[]array)
{
    for (int i = 0; i < array.Length; i ++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}



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

int PositivNum(int[]array)
{
       int count = 0;

       for (int i = 0; i < array.Length; i ++)
       {
            if (array[i] > 0)
            count ++;
         }
            return count;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[]myArray = CreateArray(size);
int result = PositivNum(myArray);
ShowArray(myArray);
Console.WriteLine("Сумма чисел больше 0: " + result);

  */



//Задача 4. Не использую рекрусию необходимо вывести первые N чисел Фибоначчи. Первые два: a и b задает пользователь.

/*
int [] Fibonacci(int n, int a, int b)
{
    int[]fibArray = new int[n];
    fibArray[0] = a;
    fibArray[1] = b;
    for( int i = 2; i < fibArray.Length; i++)
    fibArray[i] = fibArray[i -1] + fibArray[i - 2];
    return fibArray;
}
Console.Write("Введите размер ряда Фибоначчи: ");
 int fibN = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите первое число ряда: ");
 int fibA = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите второе число ряда: ");
 int fibB = Convert.ToInt32(Console.ReadLine());

 int[]arrTask3 = Fibonacci(fibN, fibA, fibB);
 ShowArray(arrTask3);
 */

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//y = 5x +2
//y = 9x + 4
//9x +4 = 5x +2
//x = -0,5
//y = 5*(-0,5)+2 = -0,5

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




*/




