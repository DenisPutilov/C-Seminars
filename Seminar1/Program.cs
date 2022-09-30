/*

// Проверка является ли число 1 квадратом числа 2

Console.Write("Input a first number ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2*n2;

if (n1 == quad2)
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}
*/

/*
// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Input a number ");
int number = Convert.ToInt32(Console.ReadLine());

int current;

if (number > 0)
{
    current = -number;
}
else
{
    current = number;
    number *= -1;
}
while (current <=number)
{
    Console.Write(current + " ");
    current++;
}
*/


// как получить младшие разряды
 // 256 % 10 -> 6
// 256 % 100 -> 56
// 256 % 1000 -> 256

// целочисленное деление
// 256 / 10 -> 56
// 256 / 100 -> 6
// 256 / 1000 -> 0

// 4827 / 10 % 100 - получим 82

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write("Input three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >=100 && n < 1000)
{
    int lastdigit = n % 10;
    Console.WriteLine($"Last digit of {n} is {n%10}");
}
else 
{
    Console.WriteLine("Incorrect input");
}