// Task 1. Задача 10: Напишите программу, 
//         которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int number = EnterNum("Введите трёхзначное число: ");
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трёхзначное число");
}
else
{
    Console.WriteLine(SecondNum(number));
}

//<-------------------Функции-------------------->
//Принимает сообщение и выводит результат.
int EnterNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SecondNum(int a)
{
    int result = ((a / 10) % 10);
    return result;
}


// Task 2. Задача 13: Напишите программу, 
//         которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = EnterNum("Введите число: ");
int count = number.ToString().Length;
Console.Write(Performs(number, count));

//<------------Функции------------>
//Принимает сообщение и выводит результат.
int EnterNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//Принимает число введенное пользователем, количество символов, 
//и выводит третью цифру числа. Если 3 цифры нет, сообщает и выводит 0.
int Performs(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет, держи: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}


// Task 3. Задача 15: Напишите программу, которая принимает на вход цифру, 
//         обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет


int dayNumber = EnterNum("Введите число от 1 до 7: ");
Console.WriteLine(Weekend(dayNumber));

// //<------------Функции------------>
// //Принимает сообщение и выводит его.
int EnterNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//Принимает число от 1 до 7 и выводит сообщение - выходной день или нет.

string Weekend(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write($"{a} -> да это выходной");
        }
        else
        {
            Console.Write($"{a} -> нет это рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, не возможно определить какой");
    }
    return " день.";
}