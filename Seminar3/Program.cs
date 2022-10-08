/*

// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int FindQuart(double x, double y)
{
    int quart = 0;

    if (x > 0 && y > 0) quart = 1;
    if (x < 0 && y > 0) quart =  2;
    if (x < 0 && y < 0) quart =  3;
    if (x > 0 && y < 0) quart =  4;
    return quart;
}

Console.Write("Input x-coordinate: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"The point A ({x},{y}) is on the {FindQuart(x,y)} quart");

*/

/*
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

void Coordinates(int q)
{
    if (q == 1) Console.WriteLine("x>0 && y>0");
    if (q == 2) Console.WriteLine("x<0 && y>0");
    if (q == 3) Console.WriteLine("x<0 && y<0");
    if (q == 4) Console.WriteLine("x>0 && y<0");
    if (q < 1 || q > 4) Console.WriteLine("No quart");
}

Console.Write("Input number of quart: ");
int q = Convert.ToInt32(Console.ReadLine());

Coordinates(q);

*/


/*
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double FindDistance(double x1, double x2, double y1, double y2)
{
    double distance =  Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
    return distance;
}

Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double dis = FindDistance(x1, x2, y1, y2);
Console.WriteLine($"Distance between point is - {dis}");
*/





// Напишите программу, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N.

void SquareLine(int number)
{
    int count = 1;

    if (number < 1)
    {
        Console.WriteLine("Input number more 1");
    }
    else
    {
    while (count <= number)
    {
        Console.WriteLine(Math.Pow(count,2));
        count++;
    }
    }
    
}

Console.Write("Input number: ");
int number = Convert.ToInt16(Console.ReadLine());
SquareLine(number);
