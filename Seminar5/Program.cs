

// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Creating of array");

    for(int i = 0; i < size; i++)
    {
        Console.Write($"input a {i + 1} elements of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("/nComplete!");
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumOfNegatives(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
int result = SumOfNegatives(myArray);

ShowArray(myArray);
Console.WriteLine("Sum of a negatives is " + result);
*/


// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    Console.Write("Creating of array");

    for(int i = 0; i < size; i++)
    {
        Console.Write($"input a {i + 1} elements of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("/nComplete!");
    return array;
}
*/

int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i=0; i<size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int[] ChangeArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] *= -1;

    return array;
}

int[] rndArray = CreateRandomArray(10, -100, 100);
ShowArray(rndArray);
Console.WriteLine("Changed array");
int[] myArray = ChangeArray(rndArray);
ShowArray(myArray);





// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
bool FindNumInArray(int[] array, int num)
{
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
}


int[] rndArray2 = CreateRandomArray(10, -100, 100);
ShowArray(rndArray2);
Console.Write("Imput number to find in massive: ");
int findNumber = Convert.ToInt32(Console.ReadLine());

bool result = FindNumInArray(rndArray2, findNumber);
if (result) Console.WriteLine($"Number {findNumber} is in massive");
else Console.WriteLine($"number {findNumber} is not in massive");
*/

// Задайте одномерный массив из 12 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

/*
int FindAccord(int[] array, int min, int max)
{
    int count = 0;

    for (int i =0; i < array.Length; i++)
    {
        if (min <= array[i] && array[i] <= max) count++;

    }
    return count;
}

int[] rndArray3 = CreateRandomArray(12, -1000, 1000);
ShowArray(rndArray3);
Console.Write("Input min range of search: ");
int minFind = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max range of search: ");
int maxFind = Convert.ToInt32(Console.ReadLine());



int result = FindAccord(rndArray3, minFind, maxFind);
Console.WriteLine($"Количество элементов массива, лежащих в отрезке от {minFind} до {maxFind} равно {result}");
*/


// https://github.com/AlexandrYodaXD/HomeWorks/blob/main/C%23/hw4/Program.cs#L8
