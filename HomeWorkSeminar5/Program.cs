/*
int [] RandomArray (int size)
{
    int [] newArray = new int [size];

    for (int i= 0; i < size; i++)
    newArray[i] = new Random().Next(99, 1000);

return newArray;


}

int [] RandomArray1 (int size)  //Не используется в выполнении ДЗ, так как генерирует сумашедшие числа, но по условию 2 задачи - надо сделать//
{
    int [] newArray = new int [size];

    for (int i= 0; i < size; i++)
    newArray[i] = new Random().Next();

return newArray;


}

double [] Double (int size)
{
    double [] newArray = new double [size];

    for (int i= 0; i < size; i++)
    newArray[i] = new Random().NextDouble();

return newArray;

}

void ShowArray (int [] array)
{
   for (int i = 0; i < array.Length; i++)
   Console.Write(array [i]+ "   ");

   Console.WriteLine();

}

void ShowDoubleArray (double [] array)
{
   for (int i = 0; i < array.Length; i++)
   Console.Write(array [i]+ "   ");

   Console.WriteLine();

}


int Count (int [] newArray)
{
   int count = 0;

   for (int i = 0; i < newArray.Length; i++)
        if (newArray[i] % 2 == 0)
        count ++;
   
return count;
}   

int Sum (int [] newArray)
{
   int sum = 0;

   for (int i = 0; i < newArray.Length; i++)
        if (i % 2 != 0)
        sum = sum + newArray[i]; //здесь рассматриваются НЕЧЕТНЫЕ для программы; если надо НЕЧЕТНЫЕ с тз пользователя, то надо сменить условие нечетности на условие четности//
   
return sum;

}

double Difference (double [] newArray)
{

double max = newArray[0];
double min = newArray[0];

   for (int i = 1; i < newArray.Length; i++) 

   {
         if (max < newArray[i])
         max = newArray[i];
    
        if (min > newArray[i])
        min = newArray[i];
    }
   
double diff = max - min;

return diff;

}
*/

// 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.//

/*
Console.WriteLine("Input size of array:   ");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = RandomArray(size);
ShowArray(array);

Console.WriteLine("Count of even-numbered is:   " + Count(array));
*/

//2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.//
/*
Console.WriteLine("Input size of array:   ");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = RandomArray(size);
ShowArray(array);

Console.WriteLine("Sum of elements in odd positions is:   " + Sum(array)); 
*/


// 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.//
/*
Console.WriteLine("Input size of array:   ");
int size = Convert.ToInt32(Console.ReadLine());

double [] array = Double(size);
ShowDoubleArray(array);

Console.WriteLine("The difference between the maximum and minimum element is:  " + Difference(array));
*/