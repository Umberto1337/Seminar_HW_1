// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) 
// {
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++) 
//     {
//         for (int j = 0; j < columns; j++) 
//         {
//             array[i, j] = new Random().Next(minValue, maxValue +1);
//         }
//     }
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// Задайте двумерный массив. Напишите программу, которая поменяет местами любые 2 строки массива.
// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine(); 
//     }
//     Console.WriteLine();
// }

// void ReversArray (int[,] array, int row1, int row2)
// {
//     if(row1 == row2 && row1 < array.GetLength(0) && row2 < array.GetLength(0)) Console.WriteLine("Строки равны замена не требуется или таких строк нет");
//     else
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1,j];
//             array[row1,j] = array[row2,j];
//             array[row2,j] = temp;
//         }
//     }
// }

// Console.Write("Введите колличество строк = ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите колличество столбцов = ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение массива = ");
// int miValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение массива = ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(rows, columns, miValue, maxValue);
// Show2dArray(myArray);

// Console.Write("Введите первую струко для замены = ");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите вторую струко для замены = ");
// int row2 = Convert.ToInt32(Console.ReadLine());
// ReversArray(myArray, row1, row2);
// Show2dArray(myArray);


// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
