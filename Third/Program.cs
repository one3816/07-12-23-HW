// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.
int[,] GetArray(int x, int y, int min, int max)
{
    int[,] array = new int[x, y];
    Random rand = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            array[i, j] = rand.Next(min, max);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

int Search(int[,]arr)
{
    int min = 9999999;
    int result = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i,j]; 
        }
        if(sum<min)
        {
            min = sum;
            result = i;
        }
    }
return result;
}

int[,] array = GetArray(3,3,1,9);
Console.WriteLine();
Console.WriteLine("Строка с индексом: " + Search(array));