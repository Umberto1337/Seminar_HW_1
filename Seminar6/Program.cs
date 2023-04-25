// Task 1. Напишите программу, которая перевернёт одномерный массив 
//         (последний элемент будет на первом месте, а первый - на последнем и т.д.)

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

// void ReverseArray(int[] array)
// {
//     for(int i = 0, j = array.Length - 1; i < j; i++, j--)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
// }

// Console.Write("Input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);
// ReverseArray(myArray);
// ShowArray(myArray);


// Task 2. Напишите программу, которая принимает на вход три числа и проверяет, 
//         может ли существовать треугольник с сторонами такой длины.(bool)
// bool CheckTrin(int l1, int l2, int l3)
// {
//     if (l1<l2+l3 && l2<l1+l3 && l3<l1+l2) return true;
//     return false;
// }

// Console.WriteLine("Input size 1 - ");
// int l1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input size 1 - ");
// int l2=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input size 1 - ");
// int l3=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ($" По заданным длинам труегольник -  {CheckTrin (l1,l2,l3)} " );

// Task 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// int[] Fibonacci (int num1, int num2, int razm)
// {
//     int[] array = new int[razm];
//     array[0]=num1;
//     array[1]=num2;
//     for (int i=2; i<razm; i++) array[i]=array[i-1]+array[i-2];
//     return array;
// }

// Console.Write ("Введите кол-во эл-в ряда - ");
// int razm = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите превое значние ряда - ");
// int num1= Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите превое значние ряда - ");
// int num2= Convert.ToInt32(Console.ReadLine());

// int[] fibArray= Fibonacci(num1,num2,razm);

// ShowArray (fibArray);



// Task 4. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// void PrintArray(int[] arrayToPrint)
// {
//     Console.Write("[");
//     for (int i = 0; i < arrayToPrint.Length; i++)
//     {
//         Console.Write("{0}", arrayToPrint[i]);
//         if (i < arrayToPrint.Length - 1)
//         {
//             Console.Write("   ");
//         }
//     }
//     Console.WriteLine("]");
// }

// void FillArray(int[] arrayToFill, int diviation)
// {
//     for (int i = 0; i < arrayToFill.Length; i++)
//         arrayToFill[i] = new Random().Next(-diviation, diviation + 1);
// }

// void CopyArray(int[] arrayToCopy, int[] arrayToFill)
// {
//     for (int i = 0; i < arrayToCopy.Length; i++)
//         arrayToFill[i] = arrayToCopy[i];
// }


// int arraySize = 0;

// arraySize = new Random().Next(5, 20);
// int[] firstArray = new int[arraySize];
// int[] secondArray = new int[arraySize];
// FillArray(firstArray, 20);
// CopyArray(firstArray, secondArray);
// Console.Clear();

// Console.WriteLine("Первый массив:");
// PrintArray(firstArray);
// Console.WriteLine();
// Console.ForegroundColor = ConsoleColor.Green;
// Console.WriteLine("Второй массив - копия первого:");
// PrintArray(secondArray);
// Console.ResetColor();


// // result 2.

// Console.Write("Input a quantity of elements array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a minimum possible element: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a maximum possible element: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] myArray = CreatRandomArray (size,min,max);   // Гененрируем массив

// int [] CopyArray (int[] array)
// {
//     int[] mas = new int [array.Length];
//     for (int i=0; i<array.Length; i++) mas[i]=array[i]+1;
//     return mas;
// }

// ShowArray(myArray);
// int [] newArray= CopyArray(myArray);
// ShowArray(newArray);