// Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.
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

void Return(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int temp = arr[0, i];
        arr[0, i] = arr[arr.GetLength(0) - 1, i];
        arr[arr.GetLength(0) - 1, i] = temp;
    }
}
void PrintArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            Console.Write(ar[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] array = GetArray(9,9,1,9);
Console.WriteLine();
Return(array);
PrintArray(array);
