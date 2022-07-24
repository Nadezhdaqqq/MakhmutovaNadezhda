
double[,] CreatRandom2dArrayDouble(int rows, int columns)
{
    double[,] newArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().NextDouble();

    return newArray;

}

void Show2dArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

            Console.Write(array[i, j] + "  ");

        Console.WriteLine();
    }

}


int[,] CreatRandom2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(0, 1000);

    return newArray;

}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

            Console.Write(array[i, j] + "  ");

        Console.WriteLine();
    }

}

void Index(int[,] array)
{
    Console.Write("Input the row:   ");
    int i = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input the column:   ");
    int j = Convert.ToInt32(Console.ReadLine());

    if (i < 0 || i > array.GetLength(0) - 1 || j < 0 || j > array.GetLength(1) - 1)

        Console.WriteLine("The element does not exist");

    else

        Console.Write(array[i, j]);


}

void AverageSum (int [,] array)
{
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{ sum / array.GetLength(0)} ");
}
Console.ReadLine();

}






//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами//

/*
Console.Write("Input num of rows:   ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input num of colomns:   ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] myArray = CreatRandom2dArrayDouble(m, n);
Show2dArrayDouble(myArray);
*/

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.//
/*
Console.Write("Input quantity of rows:   ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input quantity of columns:   ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreatRandom2dArray(m, n);
Show2dArray(myArray);
Console.WriteLine("");

Index (myArray);
*/

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.//

Console.Write("Input quantity of rows:   ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input quantity of columns:   ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreatRandom2dArray(m, n);
Show2dArray(myArray);
Console.WriteLine("");

AverageSum(myArray);