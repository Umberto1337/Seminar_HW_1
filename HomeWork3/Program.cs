// Task 1. Напишите программу, которая принимает на вход число и проверяет, 
//         является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Palindrome(int n)
{
    int nn = n;
    int r = 0; 

    while (n > 0)
    {
        r = r*10+n%10;
        n = n/10;
    }
    return r == nn;
}

void Main()
{
    int n;
    Console.Write("n = ");
    n = Convert.ToInt32(Console.ReadLine());
    if (Palindrome(n))
    {
        Console.WriteLine("палиндром");
    }
    else
    {
        Console.WriteLine("не палиндром");
    }
}

Main();


// Task 2. Напишите программу, которая принимает на вход координаты двух точек 
//         и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Gipot (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distX = x2-x1;
    double distY = y2-y1;
    double distZ = z2-z1;
    double result = Math.Sqrt(distX*distX + distY*distY + distZ*distZ);
    return result;
}

int EnterNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int x1 = EnterNum("Введите значение x1 - ");
int y1 = EnterNum("Введите значение y1 - ");
int z1 = EnterNum("Введите значение z1 - ");
int x2 = EnterNum("Введите значение x2 - ");
int y2 = EnterNum("Введите значение y2 - ");
int z2 = EnterNum("Введите значение z2 - ");

double rez = Math.Round(Gipot (x1,y1,z1,x2,y2,z2),2);

Console.Write ($"Расстояние между точками 1 и 2  составляет  - {rez}");


// Task 3. Напишите программу, которая принимает на вход число (N) 
//         и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int EnterNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void CubeTable(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"{i*i*i} ");
    }
}

int num = EnterNum("Введите число N: ");
CubeTable(num);
