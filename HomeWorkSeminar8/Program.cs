
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

int FindRow (int [,] array) 
{

int min = 0;
int indexMin = 0;

for (int i = 0; i < array.GetLength(0); i++)
{  
    int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)  
        {
            sum = sum + array[i,j];
        }
        if (i == 0) min = sum;
        if (sum < min)
            {
              min = sum;
              indexMin = i;
            }
}
return indexMin;

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


//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.//
/*
Console.Write("Input quantity of rows:   ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input quantity of columns (The quantity of columns must be less than the quantity of rows):   ");
int n = Convert.ToInt32(Console.ReadLine());

if (m <= n)
Console.Write("You entered the wrong quantity of columns");
else

{
int[,] myArray = CreatRandom2dArray(m, n);
Show2dArray(myArray);
Console.WriteLine("");

Console.Write($"The smallest sum of elements in a row:    {FindRow(myArray)+1}");

}
*/

//Заполните спирально массив 4 на 4.//


int[,] newArray = new int[4, 4];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= newArray.GetLength(0) * newArray.GetLength(1))
{
  newArray[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < newArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= newArray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > newArray.GetLength(1) - 1)
    j--;
  else
    i--;
}

Show2dArray(newArray);










