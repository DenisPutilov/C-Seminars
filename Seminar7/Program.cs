// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.


int[,] CreateRandom2DArray()
{
    Console.Write("input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array; 
}


void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

/*
int[,] myArray = CreateRandom2DArray();
Show2DArray(myArray);
*/

// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aij = i+j. 
// Выведите полученный массив на экран.

/*
int[,] Create2DArray()
{
    Console.Write("input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = i + j;

    return array; 
}

int[,] myArray = Create2DArray();
Show2DArray(myArray);
*/

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

int[,] rndArray2 = CreateRandom2DArray();
Show2DArray(rndArray2);

int[,] quadArray(int[,] rndArray2)
{
    for(int i = 0; i < rndArray2.GetLength(0); i+=2)
    {
        for(int j = 0; j < rndArray2.GetLength(1); j+=2)
            rndArray2[i,j] *= rndArray2[i,j];
    }
    return rndArray2;
}

Console.WriteLine();
int[,] resArray = quadArray(rndArray2);
Show2DArray(resArray);

// Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

/*
int[,] myArray = CreateRandom2DArray();
Show2DArray(myArray);

int SumOfDiagonalElements(int[,] myArray)
{
    int sum = 0;
    
    for(int i = 0; i < myArray.GetLength(0) && i < myArray.GetLength(1); i++)
    {
            sum += myArray[i,i];
    }
    return sum;
}

int res = SumOfDiagonalElements(myArray);
Console.WriteLine($"sum of diagonal elements is {res}");
*/
