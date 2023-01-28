/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();

int GetDataFromUser(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int[,] get2DDoubleArray(int colLength, int rowLength, int start, int end)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}

void print2DArray(int[,] array)
{
    Console.Write(" \t");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int col = GetDataFromUser("Введите количество строк");
int row = GetDataFromUser("Введите количество столбцов");
int[,] array = get2DDoubleArray(col, row, -10, 10);
print2DArray(array);
Console.WriteLine(array.GetLength(0));

for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{ sum / array.GetLength(0)} \t");
}