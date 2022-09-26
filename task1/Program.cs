//Задача 1: Задайте двумерный массив. Напишите программу, которая будет находить
//          строку с наименьшей суммой элементов. 

int row = 4;
int column = 5;
int[,] array = new int[row, column];
FillArray(array);
PrintArray(array);
Console.WriteLine( "Строка с наименьшей суммой элементов имеет индекс = "
                   +$"{FindMinSumRow(FindSumRowArray(array)).Item2}");

void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[] FindSumRowArray(int[,] array)
{
    int[] sumRow = new int[array.GetLength(0)];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            sumRow[i] += array[i, j];
        }
    }
    return sumRow;
}

(int,int) FindMinSumRow(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (min >= array[i]) 
        {
            min = array[i];
            minIndex = i;
        }
    }
    return (min,minIndex);
}