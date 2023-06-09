﻿// Task 1. Напишите программу, которая на вход принимает два числа и выдаёт, 
//         какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($"Первое число {num1} больше чем второе {num2}");
}
else
{
    Console.WriteLine($"Второе число {num2} больше чем первое {num1}");
}


// Task 2. Напишите программу, которая принимает на вход три числа и 
//         выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 3 числа:");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;

if (num_2 > max)
{
    max = num_2;
}

if (num_3 > max)
{
    max = num_3;
}

Console.WriteLine("Наибольшее из введённых чисел: " + max);


//Task 3. Напишите программу, которая на вход принимает число и выдаёт, 
//        является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
    Console.WriteLine($"Число {num} является: Нечетным!");
}
else
{
    Console.WriteLine($"Число {num} является: Четным!");
}


//Task 4. Напишите программу, которая на вход принимает число (N), 
//        а на выходе показывает все чётные числа от 1 до N.

int i = 1;
bool not = true;

Console.Write("Введите число: ");
int num11 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Чётные числа от 1 до {num11}");
while(i <= num11)
{
    if(i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}

if(not)
{
    Console.WriteLine("Нет чётных чисел!");
}


// Задача про двух друзей и собаку

int distance = 10000;
int first_friend_speed = 1;
int second_friend_speed = 2;
int dog_speed = 5;
int time;
int friend = 2;

int count = 0;

while(distance > 10)
{
    if(friend == 1)
    {
        time = distance / (first_friend_speed + dog_speed);
        friend = 2;
        distance = distance - (first_friend_speed + second_friend_speed) * time;       
    }
    count++;
    if(friend == 2)
    {
        time = distance / (second_friend_speed + dog_speed);
        friend = 1;
        distance = distance - (first_friend_speed + second_friend_speed) * time;
    }
    count++;
}
Console.WriteLine($"Собака пробежит {count} раз");