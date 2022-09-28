// Задача 3. Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел 
// (размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив.
// Вариант создания функции:
// Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
// Пример:
// Массив размером 3 x 3
// 10 11 55
// 33 41 23
// 17 28 34

int row = 3;
int column = 3;
int[,] array = new int[row, column];

FillArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Random rnd = new Random();
            int k = rnd.Next(10, 100);
            while (true)
            {
                if (!Contains(array, k))
                    break;
                k = rnd.Next(10, 100);
            }
            array[i, j] = rnd.Next(10, 100);
        }
    }
}

bool Contains(int[,] array, int value)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (array[i, j] == value)
                return true;
        }
    }
    return false;
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
