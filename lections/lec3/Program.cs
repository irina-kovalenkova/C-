﻿/*
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);
*/

//Задача 1. Вывести таблицу умножения на экран
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
*/

//Задача 2. Дан текст. В тексте нужно все пробелы заменить черточками, 
//маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с".

/*
string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"
//            012
//s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

int length = text.Length;
for(int i = 0; i < length; i++)
{
    if(text[i] == oldValue) result = result + $"{newValue}";
    else result = result + $"{text[i]}";
}
return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
*/

//Задача 3. Упорядочить массив

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[]array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
PrintArray(arr);

