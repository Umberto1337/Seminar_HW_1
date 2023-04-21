// // Task 1. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// int QuantityOfDigits(int number)
// {
//     int quantity = 0;
//     if(number == 0) quantity = 1;

//     while(number != 0)
//     {
//         number /= 10;
//         quantity++;
//     }

//     return quantity;
// }

// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = QuantityOfDigits(num);
// Console.WriteLine($"Tour number contains {result} digits");


// // Task 2. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int Sum (int num)
// {
//     int sum = 0;
//     for(int count = 1; count<=num; count++)
//     {
//         sum = sum+count;
//     }
//     return sum;
// }

// Console.WriteLine("Введите число - ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Сумма чисел от 1 до {num} сщстовляет {Sum(num)}");


// // Task3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// int Proisv (int num)
// {
//     int proisv = 1;
//     if(num < 1) proisv = 0;
//     for(int count = 1; count<=Math.Abs(num); count++)
//     {
//         proisv = proisv*count;
//     }
//     return proisv;
// }

// Console.WriteLine("Введите число - ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Произведение чисел от 1 до {num} состовляет {Proisv(num)}");