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

/*int number = 987654;
int SecondDigitNumber(int num)
{
    int result;

    
    int ed = num % 10;
    result = ed;
   
       return result;
}
//Console.Write("Enter a three-digit number: ");
//int number = Convert.ToInt32(Console.ReadLine());

int secondDigitNumber = SecondDigitNumber(number);
Console.WriteLine("The number in the middle :" + secondDigitNumber);*/

/*
int str = 987;

int str = Convert.ToString();
Console.WriteLine(str[2]);

//int str1 = str % 1;
//Console.WriteLine(str1);

*/


/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

/*
//string WeekendNumber (int num)
//{
int num = 7;                 //Convert.ToInt32(Console.ReadLine()); 
//Console.Write("Input number: ");

string result;
if(num == 1 || num == 2 || num == 3 || num == 4 || num ==5)
{
    result = "No";
}
else
{
    result = "Yes";
}
//return result;
//}


//string res = WeekendNumber(num);
Console.WriteLine(result);
*/

bool IsDayAHoliday(int day)
{
    bool result;
    if (day == 6 ^ day == 7)
        result = true;
    else
        result = false;
    
    return result;
}
Console.Write("Input a number of the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
bool isDayAHoliday = IsDayAHoliday(dayNumber);
if (isDayAHoliday)
    Console.WriteLine($"Yes, the {dayNumber} day of the week is a holiday! :)");
else
    Console.WriteLine($"No, the {dayNumber} day of the week is not a holiday! :(");

//AlexandrYodaXD/HomeWorks
