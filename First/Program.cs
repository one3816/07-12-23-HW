// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет

int[,] GetArray()
{
    int[,] array = new int[4, 3];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}
void Search(int[,] ar)
{
    Console.Write("Введите строку искомого элемента:");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите столбец искомого элемента:");
    int number2 = Convert.ToInt32(Console.ReadLine());
    if (number < ar.GetLength(0) && number2 < ar.GetLength(1))
    {
        Console.Write(ar[number,number2]);
    }
    else
    {
        Console.Write("Такого элемента нет");
    }
}

int[,] arr = GetArray();
Search(arr);