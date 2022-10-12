// Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причем, x не равен 0 и y не равен 0, и выдает номер четверти плоскости в которой находится эта точка.
/*
int FindQuart(double x, double y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.Write("Input x - coordinate: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y - coordinate: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"The point A({x},{y}) is on the {FindQuart(x,y)} quart");
*/

// задача 2. Напишите программу, которая по заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (x и y)
/*
void FindRange(int quart)
{
    if(quart == 1)
    {
        Console.WriteLine("x > 0 && y > 0");
    }
    if(quart == 2)
    {
        Console.WriteLine("x < 0 && y > 0");
    }
    if(quart == 3)
    {
        Console.WriteLine("x < 0 && y < 0");
        }
        if(quart == 4)
        {
            Console.WriteLine("x > 0 && y < 0");
        }
}
Console.Write("Input quart: ");
int quart = Convert.ToInt32(Console.ReadLine());
FindRange(quart);
*/

//Задача 3. напишите программу, которая прринимает на вход координаты двух точек и находит 
//расстояние между ними в 2Д пространстве.
/*
double Dictance(double xa, double xb, double ya, double yb)
{
    return Math.Sqrt(Math.Pow((xb - xa), 2)* Math.Pow((yb - ya),2));
}
Console.Write("Input xa - coordinate: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input xb - coordinate: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input ya - coordinate: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yb - coordinate: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Dictance(xa, xb, ya, yb));
*/

//Задача 4. Напишите программу, которая принимает на вход число N и 
//выводит квадраты чисел от 1 до N
/*
void WriteQ (int n)
{
    int count = 1;
    while (count <= n)
    {
        Console.WriteLine(Math.Pow(count, 2));
        count++;
    }
}
Console.WriteLine("Input N number: ");
int n = Convert.ToInt32(Console.ReadLine());
WriteQ(n);
*/

