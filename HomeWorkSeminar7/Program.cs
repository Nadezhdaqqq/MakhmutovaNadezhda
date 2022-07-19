
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


int [,] CreatRandom2dArray (int rows, int columns)
{
int [,] newArray = new int [rows, columns];

    for (int i = 0; i < rows; i++)
      for (int j = 0; j < columns; j++)
        newArray [i, j] = new Random().Next(0, 1000);

return newArray;

}

void Show2dArray(int [,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j =0; j < array.GetLength(1); j++)

        Console.Write(array[i, j] + "  ");

        Console.WriteLine();
    }

}

void Index (int [,] array)
{Console.Write("Input the row:   ");
int i = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the column:   ");
int j = Convert.ToInt32(Console.ReadLine());

     for (i = 0; i < array.GetLength(0); i++)
            
                for (j = 0; j < array.GetLength(1); j++)
                
       if (i < 0 || i > array.GetLength(0) - 1 || j < 0 || j > array.GetLength(1) - 1)
            
                Console.WriteLine("Элемент не существует");
            
            else
                { array[i, j] = ;                                //беда
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            
           
    
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

Console.Write("Input num of rows:   ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input num of columns:   ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreatRandom2dArray(m, n);
Show2dArray(myArray);
Console.WriteLine("");

Index (myArray);
