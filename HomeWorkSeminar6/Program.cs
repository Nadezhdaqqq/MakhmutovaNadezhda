
int [] RandomArray (int size)
{
    int [] newArray = new int [size];

    for (int i= 0; i < size; i++)
    newArray[i] = new Random().Next(-1000, 1000);

return newArray;

}

void ShowArray (int [] array)
{
   for (int i = 0; i < array.Length; i++)
   Console.Write(array [i]+ "   ");

   Console.WriteLine();

}

int PositiveNumb (int [] newArray)
{
    int count = 0;

   for (int i = 0; i < newArray.Length; i++)
        if (newArray[i] > 0)
        count ++;
   
return count;
}   




//1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.//

Console.WriteLine("Input m:   ");
int m = Convert.ToInt32(Console.ReadLine());

int [] array = RandomArray(m);
ShowArray(array);

Console.WriteLine("total positive numbers is:   " + PositiveNumb(array));