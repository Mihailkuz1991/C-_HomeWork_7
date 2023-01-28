/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента или же указание, что 
такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет

*/

Console.Clear();

int GetDataFromUser(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int[,] get2DArray(int colLength, int rowLength, int start, int end)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = new Random().Next(start, end + 1);
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
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }

}

int row = GetDataFromUser("Введите количество строк");
int col = GetDataFromUser("Введите количество столбцов");


int[,] array = get2DArray(row,col,0,10);
print2DArray(array);

int n = GetDataFromUser("Введите строку искомого элемента");
int m = GetDataFromUser("Введите столбец искомого элемента");

if (n > array.GetLength(0) || m > array.GetLength(1))
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
{
    Console.Write($"В строке {n} истолбце {m} число {array[n-1,m-1]}");
}
