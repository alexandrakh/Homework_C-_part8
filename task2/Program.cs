// Задача 2: Задайте две квадратные матрицы одного размера. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int row = 2;
int column = 2;

int[,] array1 = new int[row, column];
int[,] array2 = new int[row, column];

FillArray(array1);
FillArray(array2);

System.Console.WriteLine("Матрица 1: ");
PrintArray(array1);
System.Console.WriteLine("Матрица 2: ");
PrintArray(array2); 
System.Console.WriteLine("Произведение двух матриц: ");
PrintArray(GetMultArray(array1,array2));

void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = rnd.Next(1, 6);
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

int[,] GetMultArray(int[,] array1, int[,] array2)
{
    int[,] multArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < row; k++)
            {
                multArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return multArray;
}