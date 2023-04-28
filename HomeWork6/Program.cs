// // Task 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3

void Main(int[] args)
{
    int count = 0;
    for(int i = 0; i < args.Length; i++)
    {
        if(args[i] > 0)
        {
            count++;
        } 
    }
    Console.WriteLine($"Кол-во чисел больше 0 равен: {count}");
}

Console.Write("Введите эелементы через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Main(array);


// // Task 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// //         заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double EnterNum(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}


void FindIntersection(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    if (k1 == k2)
    {
        if (b1 == b2)
        
            Console.Write("Паралельные совпадают");
        
        else
        
            Console.Write("Прямые паралельные");
    }    
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        Console.WriteLine($"Пересичение в точке: {x} {y}");
    }
   
}


double b1 = EnterNum("Введите b1: ");
double k1 = EnterNum("Введите k1: ");
double b2 = EnterNum("Введите b2: ");
double k2 = EnterNum("Введите k2: ");
FindIntersection(b1, k1, b2, k2);