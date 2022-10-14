// Задача 1. Напишите программу, которая на вход принимает число (А)
//и выдает сумму чисел от 1 до А
/*
int GetSum(int a)
{
    int sum = 0;
    for(int current = 1; current <= a; current ++)
    {
        sum += current;
    }
    return sum;
}
Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int s = GetSum(num);
Console.WriteLine($"Sum of elements from 1 to {num} is {s}");
*/

// Задача 2. Напишите программу, которая на вход принимает число и выдает
//количество цифр в числе.
/*
int NumberOfDigit(int num)
{
    int div = 10;
    int cur = 1;
    int n = num;
    while (n > 10)
    {
        n = num / div;
        div *= 10;
        cur ++;
    }
    return cur;
}
Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = NumberOfDigit(num);
Console.WriteLine(res);
*/

//Задача 3. Напишите программу, которая на вход принимает число N и выдает 
//произведение чисел от 1 до N (N!)
/*
Console.Clear();
int Factorial(int N)
{
    int fact = 0;
    for (int current = 1; current <= N; current ++)
{
    fact += current; 
}
    return fact;
    }
Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int fact = Factorial(num);
Console.WriteLine(fact);
*/

//Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и еденицами в случайном порядке.
/*
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

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 1;
int[]myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
*/




// 2 Вариант 2 задачи
/*
Console.Clear();
int NumbersDigit (int num)
{
    int count = 0;
    while (num >0 )
    {
        num/= 10;
        count ++;
    }
    return count;
}
Console.WriteLine("Enter a number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = NumbersDigit(a);
Console.WriteLine(result);
Console.ReadLine();
*/

//Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и еденицами в случайном порядке.

int []CreateRandomArray(int size, int minValue, int maxValue)
{
    int[]newArray = new int[size];

    if(size <= 0) (size = 1);

    
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



Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 1;
int[]myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);




