// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

//Решение:
/*
Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
if(a>b)max = a;
max =b;
Console.Write("max = ");
Console.WriteLine(max);
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

//Решение:
/*
Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int c = Convert.ToInt32(Console.ReadLine());


int max = a;
if(b>max)max = b;
if(c>max)max = c;
Console.Write("max = ");
Console.WriteLine(max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*4 -> да
-3 -> нет
7 -> нет*/

//Решение:
/*
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number%2;
if(a==0)
{
    Console.WriteLine("да");
    }
else
{
Console.WriteLine("нет");
}
*/

//Задача 4!

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 2;
while(current <+ number)
{
    Console.Write(current + " ");
    current = current + 2;
}
