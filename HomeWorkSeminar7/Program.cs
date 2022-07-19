
double [,] CreatRandom2dArrayDouble (int rows, int columns)
{
double [,] newArray = new double [rows, columns];

    for (int i = 0; i < rows; i++)
      for (int j = 0; j < columns; j++)
        newArray [i, j] = new Random().NextDouble();

return newArray;

}

void Show2dArrayDouble (double [,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j =0; j < array.GetLength(1); j++)

        Console.Write(array[i, j] + "  ");

        Console.WriteLine();
    }

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