//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе//
/*
int Sum(int n)
{

int sum = 0;

while (n > 0)
{
    int current = n % 10;
    n = n / 10;
   sum = sum + current;
}

return sum;

}


Console.WriteLine("Input n:  ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Sum(n));
*/



// Напишите программу, которая задаёт массив из m элементов и выводит их на экран.//


int [] RandomArray (int size, int min, int max)
{
    int [] newArray = new int [size];

    for (int i= 0; i < size; i++)
    newArray[i] = new Random().Next(min, max+1);

return newArray;


}

void ShowArray (int [] array)
{
   for (int i = 0; i < array.Length; i++)
   Console.Write(array [i]+ "   ");

   Console.WriteLine();

}
    
Console.WriteLine("Input size of array:   ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min element of array:   ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max element of arra:   ");
int max = Convert.ToInt32(Console.ReadLine());


int [] array = RandomArray(m, min, max);
ShowArray(array);



