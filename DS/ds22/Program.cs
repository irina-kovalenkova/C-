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

