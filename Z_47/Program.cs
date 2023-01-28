/*Задача 47. Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

Console.Clear();

int GetDataFromUser(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

double[,] get2DDoubleArray(int colLength, int rowLength, int start, int end)
{
    double[,] array = new double[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = new Random().Next(start, end + 1) + Math.Round(new Random().NextDouble(),2);
        }
    }
    return array;
}

void print2DArray(double[,] array)
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

int n = GetDataFromUser("Введите количество строк");
int m = GetDataFromUser("Введите количество столбцов");
double[,] array = get2DDoubleArray(n,m,-10,10);
print2DArray(array);