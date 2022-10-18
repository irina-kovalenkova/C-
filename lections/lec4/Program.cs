/*
int[,]matrix = new int [3,4];
for (int i = 0; i < 3; i ++)
{
    for (int j = 0; j < 4; j ++)
    {
        Console.Write($"{matrix[i, j]}");
    }
    Console.WriteLine();
    }

*/

//Задача. Разукрасить руку.

int [,]pic = new int[23, 25];
void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i,j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}
PrintImage(pic);





    
