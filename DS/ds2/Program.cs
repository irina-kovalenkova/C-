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

int number = 98;
int SecondDigitNumber(int num)
{
    int result;

    
    int ed = num / 1000;
    result = ed;
   
       return result;
}
//Console.Write("Enter a three-digit number: ");
//int number = Convert.ToInt32(Console.ReadLine());

int secondDigitNumber = SecondDigitNumber(number);
Console.WriteLine("The number in the middle :" + secondDigitNumber);







/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

