// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int GetSum(int a)
{
    int sum = 0;

    for (int current = 1; current <= a; current++)
        sum += current;

    return sum;
}

Console.Write("input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int s = GetSum(num);
Console.WriteLine($"Sum of elements from 1 to {num} is {s}");
*/

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int DigitNumbers(int num)
{
    int div = 10;
    int cur = 1;

    for(int n = num;n >10; cur++)
    {
        n = num / div;
        div*=10;
    }
    return cur;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int f = DigitNumbers(number);
Console.WriteLine($"Number of digits {number} is {f}");
*/


// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*

int Factorial(int num)
{
    int fact = 1;
    for (int current = 1; current <= num; current++)
        fact *= current;
    return fact;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int f = Factorial(number);
Console.WriteLine($"Factorial of {number} is {f}");
*/

// Напишите программу, которая выводит массив из m элементов, заполненный нулями и единицами в случайном порядке.

//метод генерации массива
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i=0; i<size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

// метод вывода массива
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 1;

int[] myArray = CreateRandomArray(size, min, max);

ShowArray(myArray);