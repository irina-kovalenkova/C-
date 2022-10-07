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