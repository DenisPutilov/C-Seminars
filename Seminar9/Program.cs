// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

/*
void ShowNums(int n)
{
    if(n > 1) ShowNums(n - 1);

    Console.Write(n + " ");
}

ShowNums(6);
*/

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

/*
int SumOfDigits(int num)
{
    if(num != 0) return SumOfDigits(num / 10) + num % 10;
    else return 0;
}

Console.WriteLine(SumOfDigits(12345));
*/

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void Shownumbers(int m, int n)
{}

    if(m>n)
    {
        Console.Write($"{m} ");
        Shownumbers(m-1, n);
    } 
    if(m<n)
    {
        Console.Write($"{n} ");
        Shownumbers(m, n-1);

    if(n==m)
    {
        Console.Write($"{n} ");
    } 
}

Shownumbers(2, 5);
*/

// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.

double PowerDigits(double a, double b)
{
    if(b>0) return a * PowerDigits(a, b-1);
    if(b<0) return 1/a * PowerDigits(a, b+1);
    return 1;
}

Console.WriteLine(PowerDigits(2, 3));