// Task 1. Напишите программу, 
//         которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// int CutNumber(int num)
// {
//     int hundreds = num / 100;
//     int units = num % 10;

//     int result = hundreds * 10 + units;
//     return result;
// }

// int randNumber = new Random().Next(100, 1000);
// int shortNumber = CutNumber(randNumber);

// Console.WriteLine($"New version of of {randNumber} is {shortNumber}");


// // Task 2. Напишите программу, 
// //         которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int MaxDigits(int ranNumber)
// {
//     int units = ranNumber % 10;
//     int dozents = ranNumber / 10;
//     if (units > dozents) return units;
//     else return dozents;
// }
// int random = new Random().Next(10, 100);
// int randomNumber = MaxDigits(random);
// Console.WriteLine(random);
// Console.WriteLine(randomNumber);


// // Task 3. Напишите программу, которая будет принимать на вход два числа и выводить, 
// //        является ли второе число кратным первому.

// bool Even(int num1, int num2)
// {
//     if (num2 % num1 == 0)
//         return true;
//     else
//         return false;
// }

// Console.WriteLine("Input first number, please: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number, please: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// bool result = Even(num1, num2);
// Console.WriteLine(result);

// // Task 4. Напишите программу, которая принимает на вход число n и проверяет, 
// //         кратно ли оно одновременно a и b.

// bool Even1(int numA, int numB, int arg)
// {
//     if (numA % arg == 0 && numB % arg == 0)
//         return true;
//     else
//         return false;
// }

// Console.WriteLine("Input first number, please: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number, please: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input third number, please: ");
// int arg = Convert.ToInt32(Console.ReadLine());

// bool result1 = Even1(numA, numB, arg);
// Console.WriteLine(result1);



// // Task 5. Напишите программу, которая принимает на вход два числа и проверяет, 
// //         является ли одно число квадратом другого.

// bool Square(int num1, int num2)
// {
//     if ((num1 * num1 == num2) || (num2 * num2 == num1))
//         return true;
//     else
//         return false;
// }

// Console.WriteLine("Input first number, please: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number, please: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// bool result = Square(num1, num2);
// Console.WriteLine(result);