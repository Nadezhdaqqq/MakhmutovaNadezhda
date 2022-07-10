
int [] RandomArray (int size)
{
    int [] newArray = new int [size];

    for (int i= 0; i < size; i++)
    newArray[i] = new Random().Next(100, 1000);

return newArray;


}

int [] RandomArray1 (int size)
{
    int [] newArray = new int [size];

    for (int i= 0; i < size; i++)
    newArray[i] = new Random().Next();

return newArray;


}

/*int [] Double (int size)
{
    int [] newArray = new int [size];

    for (int i= 0; i < size; i++)
    newArray[i] = new Random().Next();

return newArray;


}

*/







void ShowArray (int [] array)
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
        sum = sum + newArray[i]; //здесь рассматриваются НЕЧЕТНЫЕ для программы; если надо НЕЧЕТНЫЕ с тч пользователя, то надо сменить условие нечетности на условие четности//
   
return sum;

}

// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.//

/*
Console.WriteLine("Input size of array:   ");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = RandomArray(size);
ShowArray(array);

Console.WriteLine("Count of even-numbered is:   " + Count(array));
*/

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.//
/*
Console.WriteLine("Input size of array:   ");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = RandomArray(size);
ShowArray(array);

Console.WriteLine("Sum of elements in odd positions is:   " + Sum(array)); 
*/


// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.//