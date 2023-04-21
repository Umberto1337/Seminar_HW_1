// // Task 1. Напишите цикл, который принимает на вход два числа (A и B)
// // и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

// // Решение 1
// Console.WriteLine("введите число A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число B");
// int b = Convert.ToInt32(Console.ReadLine());
// int step = a;
// for (int i = 1; i < b; i++)
// {
// step = step * a;
// }
// Console.WriteLine("A в степени B равно: " + step);

// // Рещение 1.1
// int Enternum(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void StepNum(int a, int b)
// {
//     int step = 1;
//     for(int i = 1; i <= b; i++)
//     {
//         step = step * a;
//     }
//     Console.Write(step);
// }

// int numA = Enternum("Введите число A: ");
// int numB = Enternum("Введите число B: ");
// StepNum(numA, numB);


// // Task 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12

// // Решение 1
// Console.WriteLine("введите число");
// int i = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (i > 0)
// {
// int num = i % 10;
// i = i / 10;
// sum = sum + num;
// }
// Console.WriteLine("сумма всех цифр в числе равна: " + sum);

// // Решение 1.1
// int Enternum(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int Numberlen(int a)
// {
//     int index = 0;
//     while(a > 0)
//     {
//         a/=10;
//         index++;
//     }
//     return index;
// }


// void SumNumber(int n, int len)
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine(sum);
// }


// int unity = Enternum("Введите число: ");
// int len = Numberlen(unity);
// SumNumber(unity, len);



// // Task 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]
// // ========================================================
// // 1) c Функцией ввода

// // Функция ввода
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int lenArray = ReadInt("Введите длинну массива: ");

// int[] randomArray = new int[lenArray];
// for (int i = 0; i < randomArray.Length; i++)
// {
//     randomArray[i] = new Random().Next(1,9);
//     Console.Write(randomArray[i] + ", ");
// }

// // ========================================================
// // 2) без метода
// Console.WriteLine("Будет создан массив длиной A в диапвзоне 0-A");
// Console.Write("Введите любое число (A): ");
// int enterNumber = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[enterNumber];

// for (int i = 0; i < enterNumber; i++)
// {
//     array[i] = new Random().Next(enterNumber+1);
//     Console.Write(array[i] + ", ");
// }
// Console.WriteLine();

// // ========================================================
// // 3) Perfect
// int EnterNum(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[] CreateArr(int Length)
// {
//     int[] array = new int[Length];
//     for (int i = 0; i < Length; i ++)
//     {
//         array[i] = new Random().Next(Length + 1);
//     }
//     return array;
// }

// void ShowArr(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write($"{array[array.Length - 1]}");
//     Console.WriteLine("]");
// }

// int lenght = EnterNum("Длина массива: ");
// int[] array = CreateArr(lenght);

// ShowArr(array);
// // ========================================================