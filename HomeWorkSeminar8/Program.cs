
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

int [,] Decreasing (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)  
        {
             for (int k = 0; k < array.GetLength(1) - j - 1; k++) 
            {
                 if (array[i, k] < array[i, k + 1]) //поменять знак для сортировки по возрастанию//
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
 return array;       
}

// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.//
/*
Console.Write("Input quantity of rows:   ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input quantity of columns:   ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreatRandom2dArray(m, n);
Show2dArray(myArray);
Console.WriteLine("");


Show2dArray(Decreasing(myArray));
*/


















