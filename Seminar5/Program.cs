// // Task 1. Задайте массив из 12 элементов, 
// // заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     // объявить массив
//     int[] array = new int[size];
//     //Цикл for
//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// int GetSumOfNegatives(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//         if(array[i] < 0) 
//             sum += array[i]; 
    
//     return sum;
// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);

// Console.Write("Sum of Negative elements is " + GetSumOfNegatives(myArray));

// //==============================================================================
// // Task 2. Напишите программу замена элементов массива: 
// // положительные элементы замените на соответствующие отрицательные, и наоборот.
// int[] MakePositive(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = array[i] * (-1);
//     return array;
// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a minimum possible element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a maximum possible element: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreatRandomArray(size, min, max);
// ShowArray(myArray);
// MakePositive(myArray);
// ShowArray(myArray);


// // Task 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// bool
// bool HaveChosenNumber(int number, int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             Console.WriteLine($"There is such number in the current array.");
//             return true;
//         }
//     }
//     Console.WriteLine($"There is NO such number in the current array.");
//     return false;

// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a minimum possible element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a maximum possible element: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input chosen number, please: ");
// int chosenNum = Convert.ToInt32(Console.ReadLine());

// int[] array = CreatRandomArray(size, min, max);
// ShowArray(array);
// HaveChosenNumber(chosenNum, array);



// // Task 4. Задайте одномерный массив из m случайных чисел. 
// // Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
// int QuantityOfElements(int[] array, int min, int max)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] <= max && array[i] >= min) count++;
//     return count;
// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a minimum possible element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a maximum possible element: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input lower boarder, please: ");
// int boarderA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input top boarder, please: ");
// int boarderB = Convert.ToInt32(Console.ReadLine());

// int[] array = CreatRandomArray(size, min, max);
// ShowArray(array);
// Console.WriteLine("The quantity of elements between boarders: " + QuantityOfElements(array, boarderA, boarderB));