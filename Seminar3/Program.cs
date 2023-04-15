// // Task 1. Напишите программу, которая по заданному номеру четверти, 
// //         показывает диапазон возможных координат точек в этой четверти (x и y).

// void ShowRange(int quad)
// {
//     if(quad == 1) Console.WriteLine("x > 0 and y > 0");
//     else if(quad == 2) Console.WriteLine("x < 0 and y > 0");
//     else if(quad == 3) Console.WriteLine("x < 0 and y < 0");
//     else if(quad == 4) Console.WriteLine("x > 0 and y < 0");
//     else Console.WriteLine("Wrong number of quadrant");
// }

// Console.Write("Input a number of quadrant: ");
// int quadrant = Convert.ToInt32(Console.ReadLine());

// ShowRange(quadrant);

// // Task 2(void). Напишите программу, которая принимает на вход координаты точки (X и Y),
// //         и выдаёт номер четверти плоскости, в которой находится эта точка.

// void Showquad(int x, int y)
// {
//     if(x > 0 &&  y > 0) Console.WriteLine("1");
//     else if(x < 0 && y > 0) Console.WriteLine("2");
//     else if(x < 0 && y < 0) Console.WriteLine("3");
//     else if(x > 0 && y < 0) Console.WriteLine("4");
//     else Console.WriteLine("Wrong coordinates");    
// }

// Console.Write("Input coordinates x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input coordinates y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Showquad(x, y);

//  // Task 2.1(not void)
// int ShowQuad(int x, int y)
// {
//     if(x > 0 && y > 0) 
//         return 1;
//     else if(x<0 && y>0)
//         return 2;
//     else if(x<0 && y<0)
//         return 3;
//     else if(x>0 && y<0)
//         return 4;
//     else 
//         return -1;
// }
// Console.WriteLine("Input coordinates X");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input coordinates Y");
// int Y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ShowQuad(X,Y));

// // Task 3. Напишите программу, 
// //         которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// int num = EnterNum("Введите число: ");
// Quad(num);


// int EnterNum(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }


// void Quad(int num)
// {
//     int current = 1;
//     while(current <= num)
//     {
//         Console.WriteLine($"{current} - {current * current}");
//         current++;
//     }
// }

// // Task 4. Напишите программу, которая принимает на вход координаты двух точек 
// //         и находит расстояние между ними в 2D пространстве.

// double Gipot (double x1, double y1, double x2, double y2)
// {
//     double distX = x2-x1;
//     double distY = y2-y1;
//     double result = Math.Sqrt(distX*distX + distY*distY);
//     return result;
// }
// Console.Write ("Введите значение x1 - ");
// int x1 = Convert.ToInt32(Console.ReadLine()); 

// Console.Write ("Введите значение y1 - ");
// int y1 = Convert.ToInt32(Console.ReadLine()); 

// Console.Write ("Введите значение x2 - ");
// int x2 = Convert.ToInt32(Console.ReadLine()); 

// Console.Write ("Введите значение y2 - ");
// int y2 = Convert.ToInt32(Console.ReadLine()); 

// double rez = Math.Round(Gipot (x1,y1,x2,y2),4);

// Console.Write ($"Расстояние между точками 1 и 2  составляет  - {rez}");