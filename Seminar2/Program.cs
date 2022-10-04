
/*
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int FindMax(int num) //объявили входящий аргумент num

{
    int max;

    int ed = num % 10;
    int dec = num / 10;

    if (ed > dec) 
        max = ed;
    else 
        max = dec;
    return max;
}

int number = new Random().Next(10, 100); //вводим аргумент, который идет на вход метода
int biggestDigit = FindMax(number);

Console.WriteLine($"the biggest digit of {number} is {biggestDigit}");
*/

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int ThreeDigitWithoutSecond(int twoDigit)
{
    int dec = twoDigit/100;
    int ed = twoDigit%10;
    int num = dec*10+ed;
    return num;
}

int num = new Random().Next(100, 1000);
int digit = ThreeDigitWithoutSecond(num);

Console.WriteLine($"DigitOutOfSecond of number {num} is {digit}");

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b. a и b - инфо от пользователя(тоже int)

bool MultipleNumber(int number, int a, int b)
{
    bool result;

    if (number % a == 0 && number % b == 0)
    {
        result = true;
    }
    else
    {
        result = false;
    }
    return result;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input first divisor: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second divisor: ");
int b = Convert.ToInt32(Console.ReadLine());

bool res = MultipleNumber(number, a, b);
Console.WriteLine(res);
