/*
int FindBiggestDigit(int num)

{
    int max;
    int ed = num % 10;
    int dec = num / 10;

    if(ed > dec)
    max = ed;
    else 
    max = dec;
    return max;
}

int number = new Random().Next(10,100);
int biggestDigit = FindBiggestDigit(number);
Console.WriteLine($"The biggest digit of {number} is {biggestDigit}");
*/

int TwoDigitNumber(int num)
{
    int result;
    int ed = num % 10;
    int dec = num / 100;
    result = dec * 10 + ed;
    return result;
    }
    int number = new Random().Next(100,1000);
    int twoDigitNumber = TwoDigitNumber(number);
    Console.WriteLine("Number is :" + twoDigitNumber);