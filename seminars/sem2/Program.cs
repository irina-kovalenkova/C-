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