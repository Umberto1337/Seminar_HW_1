// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNumbers(int n)
{
    if (n > 0)
    {
        Console.Write(n + " ");
        PrintNumbers(n - 1);
        // Console.Write(n + " ");  
    }
    
}
PrintNumbers(8);

// Решение 2
void PrintNumbers2(int n)
{
    Console.Write(n + " ");
    if(n > 1) PrintNumbers(n - 1);
}

PrintNumbers2(5);

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalNumbers(int m, int n)
{
    if (m > n)
    {
        return 0;  // Базовый случай: если m > n, сумма равна 0
    }
    else
    {
        return m + SumNaturalNumbers(m + 1, n);  // Рекурсивный случай: суммируем текущее число m с суммой оставшегося промежутка
    }
}
int m = 1;
int n = 10;
int sum = SumNaturalNumbers(m, n);
Console.WriteLine("Сумма натуральных чисел от " + m + " до " + n + " равна: " + sum);



// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    return 0;
}

int m = 3;
int n = 2;
int result = Ackermann(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");

