// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("задайте количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("задайте количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintArray(matrix);
SortArray(matrix);
Console.WriteLine("Отсортированные элементы строк массива по убыванию:");
PrintArray(matrix);

void FillArray(int[,] array)
{
    Random random = new Random();
    int sizeRowsArray = array.GetLength(0);
    int sizeColumnsArray = array.GetLength(1);
    for (int i = 0; i < sizeRowsArray; i++)
    {
        for (int j = 0; j < sizeColumnsArray; j++)
        {
            array[i, j] = random.Next(1, 50);
        }
    }
}

void PrintArray(int[,] array)
{
    int sizeRowsArray = array.GetLength(0);
    int sizeColumnsArray = array.GetLength(1);
    for (int i = 0; i < sizeRowsArray; i++)
    {
        for (int j = 0; j < sizeColumnsArray; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
    int sizeRowsArray = array.GetLength(0);
    int sizeColumnsArray = array.GetLength(1);
    for (int i = 0; i < sizeRowsArray; i++)
    {
        for (int j = 0; j < sizeColumnsArray; j++)
        {
            for (int k = j; k < sizeColumnsArray; k++)
            {
                if (array[i, k] > array[i, j])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, j];
                    array[i, j] = temp;
                }
            }
        }
    }
}