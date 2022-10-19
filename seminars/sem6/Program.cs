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
*/

/*

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

*/

//int[] myArray = CreateRandomArray();
//ShowArray(myArray);
/*

void ChangeNumber(int a)
{
    a += 5;
    Console.WriteLine(a);
}
int num = 5;
ChangeNumber(num);
Console.WriteLine(num);

*/
/*
void ReverseArray (int[]array)
{
    for (int i = 0, last = array.Length-1; i < last; i++, last--)
    {
        int temp = array[i];
        array[i] = array[last];
        array[last] = temp;
    }
}

int[]myArray = CreateRandomArray();
ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
*/

//Задача 2. Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник со сторонами такой длины.
/*
bool ExistanceTriangle(double a, double b, double c)
{
    if (a < b + c && b < a + c && c < a + b) return true;
    return false;
}
 Console.Write("Введите размер стороны A: ");
 double sideA = Convert.ToDouble(Console.ReadLine());

 Console.Write("Введите размер стороны B: ");
 double sideB = Convert.ToDouble(Console.ReadLine());

 Console.Write("Введите размер стороны C: ");
 double sideC = Convert.ToDouble(Console.ReadLine());

bool resTask1 = ExistanceTriangle(sideA, sideB, sideC);
if (resTask1) Console.Write("Треугольник существует!");
else Console.Write("Треугольник не существует!");

*/


//Задача 3. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
/*
int[]CopyArray(int[]array)
{
    int []copy = new int [array.Length];
    for (int i = 0; i < array.Length; i ++)
    copy[i] = array[i];
    return copy;
}
int [] arrTask2 = CreateRandomArray();
ShowArray(arrTask2);
int [] copyArrTask2 = CopyArray(arrTask2);
ShowArray(arrTask2);

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