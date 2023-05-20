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

// void ShowElement(int[,] array, int posX, int posY)
// {
//     if (posX < array.GetLength(0) && posX >= 0 &&
//         posY < array.GetLength(1) && posY >= 0)
//         Console.WriteLine(array[posX, posY]);
//     else
//         Console.WriteLine("Element doesn't exist!");
// }


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

// void ReversArray(int[,] array)
// {
//     for(int i = 1; i < array.GetLength(0); i++)
//         for(int j = 0; j < i; j++)
//         {
//             int temp = array[i, j];
//             array[i, j] = array[j, i];
//             array[j, i] = temp;
//         }
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
// ReversArray(myArray);
// Show2dArray(myArray);

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
//     if(row1 < array.GetLength(0) && row1 >= 0 && row2 < array.GetLength(0) && row2 >= 0)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1,j];
//             array[row1,j] = array[row2,j];
//             array[row2,j] = temp;
//         }
//         Show2dArray(array);
//     }
//     else
//         Console.WriteLine("Таких строк нет");
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



// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
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

int[,] RemoveAndDelete(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    int smallestElement = array[0, 0];
    int smallestElementRowIndex = 0;
    int smallestElementColumnIndex = 0;

// Находим наименьший элемент и его индексы
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (array[i, j] < smallestElement)
            {
                smallestElement = array[i, j];
                smallestElementRowIndex = i;
                smallestElementColumnIndex = j;
            }
        }
    }

// Создаем новый массив без строки и столбца с наименьшим элементом
    int[,] newArray = new int[rows - 1, columns - 1];
    for (int i = 0, newRow = 0; i < rows; i++)
    {
        if (i == smallestElementRowIndex)
        {
            continue;
        }

        for (int j = 0, newColumn = 0; j < columns; j++)
        {
            if (j == smallestElementColumnIndex)
            {
                continue;
            }

            newArray[newRow, newColumn] = array[i, j];
            newColumn++;
        }

        newRow++;
    }

        // Обновляем исходный массив
    return newArray;
}


Console.Write("Введите колличество строк = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов = ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива = ");
int miValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива = ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, miValue, maxValue);
Show2dArray(myArray);
myArray = RemoveAndDelete(myArray);
Show2dArray(myArray);