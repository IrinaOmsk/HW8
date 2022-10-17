
    // Задача 56: Задайте прямоугольный двумерный массив. 
    // Напишите программу, которая будет находить строку с наименьшей 
    //суммой элементов.
    // Программа считает сумму элементов в каждой строке и выдаёт
    //  номер строки с наименьшей суммой элементов: 1 строка

Console.Write("задайте количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("задайте количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine($"Наименьшая сумма элементов у {LowSummElements(matrix)}й строки масива");

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
int LowSummElements(int[,] arr)
{
    int rowsSize = arr.GetLength(0);
    int columnsSize = arr.GetLength(1);
    int minSummRow = 0;
    int sumRowElements = 0;
    for (int j = 0; j < columnsSize; j++)
    {
        sumRowElements = sumRowElements + arr[0, j];
    }
    int MinSumm = sumRowElements;
    for (int i = 1; i < rowsSize; i++)
    {
        sumRowElements = 0;
        for (int j = 0; j < columnsSize; j++)
        {
            sumRowElements = sumRowElements + arr[i, j];
        }
        if (sumRowElements < MinSumm)
        {
            MinSumm = sumRowElements;
            minSummRow = i + 1;
        }
    }
    return minSummRow;
}