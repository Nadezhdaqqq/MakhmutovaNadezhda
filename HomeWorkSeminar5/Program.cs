// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.//


int [] RandomArray (int size)
{
    int [] newArray = new int [size];

    for (int i= 0; i < size; i++)
    newArray[i] = new Random().Next(100, 1000);

return newArray;


}

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


Console.WriteLine("Input size of array:   ");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = RandomArray(size);
ShowArray(array);

Console.WriteLine("Count of even-numbered is:   " + Count(array));