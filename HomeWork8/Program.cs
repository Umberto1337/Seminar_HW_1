// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine(); 
    }
    Console.WriteLine();
}

// Пузырьковая
// void SortRows(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - j - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1]) 
//                 {
//                     int temp = array[i, k];
//                     array[i, k] = array[i, k + 1];
//                     array[i, k + 1] = temp;
//                 }
//             }
//         }
//     }
// }

// Выбором
void SelectionSort(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxIndex = j;

            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxIndex])
                {
                    maxIndex = k;
                }
            }

            if (maxIndex != j)
            {
                int temp = array[i, j];
                array[i, j] = array[i, maxIndex];
                array[i, maxIndex] = temp;
            }
        }
    }
}

Console.Write("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int miValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, miValue, maxValue);
Show2dArray(myArray);
// SortRows(myArray);
SelectionSort(myArray);
Show2dArray(myArray);


// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine(); 
    }
    Console.WriteLine();
}

int FindRowMinSum(int[,] array)
{
    int minSum = int.MaxValue;
    int minSumRowIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum += array[i, j];
        }

        if (rowSum < minSum)
        {
            minSum = rowSum;
            minSumRowIndex++;
        }
    }

    return minSumRowIndex;

}


Console.Write("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int miValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, miValue, maxValue);
Show2dArray(myArray);
int findRow = FindRowMinSum(myArray);
Console.WriteLine($"{findRow} строка");


// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(1, 5);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine(); 
    }
    Console.WriteLine();
}

int[,] Multiply(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int columns2 = matrix2.GetLength(1);

    if (columns1 != rows2)
    {
        Console.WriteLine("Невозможно выполнить умножение");
    }

    int[,] resultMatrix = new int[rows1, columns2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            int sum = 0;

            for (int z = 0; z < columns1; z++)
            {
                sum += matrix1[i, z] * matrix2[z, j];
            }

            resultMatrix[i, j] = sum;
        }
    }

    return resultMatrix;
}


Console.Write("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = CreateRandom2dArray(rows, columns);
int[,] matrix2 = CreateRandom2dArray(rows, columns);

int[,] resultMatrix = Multiply(matrix1, matrix2);

Console.WriteLine("Матрица 1:");
Show2dArray(matrix1);
Console.WriteLine("Матрица 2:");
Show2dArray(matrix2);
Console.WriteLine("Произведение двух матриц:");
Show2dArray(resultMatrix);


// ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void Show3dArray(Array array)
{
    int dimensions = array.Rank;
    if (dimensions == 2)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
                Console.Write(array.GetValue(i, j) + " ");

            Console.WriteLine();
        }
        
    }
    else if (dimensions == 3)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        int depth = array.GetLength(2);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int k = 0; k < depth; k++)
                    Console.Write(array.GetValue(i, j, k) + " ");

                Console.WriteLine();
            }
        }
    }

    Console.WriteLine();
}

int[,,] GenerateUniqueTwoDigitArray(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int minValue = 10;
    int maxValue = 99;
    Random random = new Random();

    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            for (int k = 0; k < size3; k++)
            {
                int randomNumber;
                bool isUnique;

                do
                {
                    randomNumber = random.Next(minValue, maxValue + 1);
                    isUnique = IsUniqueNumber(array, randomNumber);
                }
                while (!isUnique);

                array[i, j, k] = randomNumber;
            }
        }
    }

    return array;
}

bool IsUniqueNumber(int[,,] array, int number)
{
    foreach (int element in array)
    {
        if (element == number)
        {
            return false;
        }
    }

    return true;
}

void Print3dArrayIndex(int[,,] array)
{
int rows = array.GetLength(0);
int columns = array.GetLength(1);
int depth = array.GetLength(2);

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.WriteLine();
        for (int k = 0; k < depth; k++)
        {
            Console.Write($"{array[i, j, k]}[{i}, {j}, {k}] ");
        }
    }
}

}


int[,,] array = GenerateUniqueTwoDigitArray(2, 2, 2);
Show3dArray(array);
Print3dArrayIndex(array);


// Напишите программу, которая заполнит спирально массив 2 на 2.
// Например, на выходе получается вот такой массив:
// 01 02
// 04 03


int[,] FillSpiralArray(int size)
{
    int[,] array = new int[size, size];
    int num = 1;
    int rowStart = 0, rowEnd = size - 1;
    int colStart = 0, colEnd = size - 1;

    while (rowStart <= rowEnd && colStart <= colEnd)
    {
        // Fill top row
        for (int i = colStart; i <= colEnd; i++)
        {
            array[rowStart, i] = num++;
        }
        rowStart++;

        // Fill right column
        for (int i = rowStart; i <= rowEnd; i++)
        {
            array[i, colEnd] = num++;
        }
        colEnd--;

        // Fill bottom row
        for (int i = colEnd; i >= colStart; i--)
        {
            array[rowEnd, i] = num++;
        }
        rowEnd--;

        // Fill left column
        for (int i = rowEnd; i >= rowStart; i--)
        {
            array[i, colStart] = num++;
        }
        colStart++;
    }

    return array;
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{array[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}


int[,] array = FillSpiralArray(4);
PrintArray(array);