// // Task 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// // m = 3, n = 4.
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9

double[,] CreateRandom2dArray(int rows, int colums)
{
    double[,] array = new double[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = Math.Round((new Random().NextDouble() * 20) - 10, 1);

    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());


double[,] myArray = CreateRandom2dArray(rows, colums);
Show2dArray(myArray);


// // Task 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// //         и возвращает значение этого элемента или же указание, что такого элемента нет.
// //Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 1 7 -> числа с такими индексами в массиве нет

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) 
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++) 
        {
            array[i, j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return array;
}

void FindElementValue(int[,] array, int row, int column) 
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int elementValue = array[column, row];
    if (row < 0 || row >= rows || column < 0 || column >= columns) 
    {
        Console.WriteLine("Числа с такими индексами в массиве нет");
        return;
    }
    Console.WriteLine("Значение элемента: " + elementValue);
}


void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input a quantioty of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantioty of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimum possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximum possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input element of row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input element of column: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
FindElementValue(myArray, column - 1, row - 1);
