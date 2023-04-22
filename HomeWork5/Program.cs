// // Task 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// //         Напишите программу, которая покажет количество чётных чисел в массиве.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    // объявить массив
    int[] array = new int[size];
    //Цикл for
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void FindEven(int[] MyArray)
{
    int even = 0;
    for(int i = 0; i < MyArray.Length; i++)
    {
        if(MyArray[i] % 2 == 0)
        {
            even++;
        }
    }
    Console.WriteLine($"Количество чётных чисел в массиве: {even}");
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
        Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
    Console.WriteLine();
}

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArr = CreateRandomArray(size, min, max);
ShowArray(myArr);
FindEven(myArr);

// //==========================================================

// // Task 2. Задайте одномерный массив, заполненный случайными числами. 
// //         Найдите сумму элементов, стоящих на нечётных позициях.
int[] GetArray(int size, int minValue, int maxValue)
{
    // объявить массив
    int[] array = new int[size];
    //Цикл for
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void SumNotEven(int[] MyArray)
{
    int sum = 0;
    for(int i = 1; i < MyArray.Length; i = i + 2)
    
        sum = sum + MyArray[i];
    
    Console.Write($"Сумма чисел на нечетных позициях: {sum}");
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
        Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
    Console.WriteLine();
}



Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArr = GetArray(size, min, max);
ShowArray(myArr);
SumNotEven(myArr);

// //========================================================

// // Task 3. Задайте массив вещественных чисел. 
// //         Найдите разницу между максимальным и минимальным элементов массива.
int[] GetArr(int size, int minValue, int maxValue)
{
    // объявить массив
    int[] array = new int[size];
    //Цикл for
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}


void FindDiff(int[] MyArray, int minVal, int maxVal)
{
    for(int i = 0; i < MyArray.Length; i++)
    {
        if(MyArray[i] < minVal)
        {
            minVal = MyArray[i];
        }
        if(MyArray[i] > maxVal)
        {
            maxVal = MyArray[i];
        }
    }
    Console.Write($"Разница между максимальным и минимальным элементом: {maxVal - minVal}");
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
        Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
    Console.WriteLine();
}


Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArr = GetArr(size, min, max);
ShowArray(myArr);
FindDiff(myArr, max, min);