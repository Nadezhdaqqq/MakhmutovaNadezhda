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


void ShowArray(int [] array)
{
  for (int i = 0; i < array.Length; i++)
  Console.Write(array[i] + "  ");
  Console.WriteLine();

}

Console.Write ("Input array size:   ");
int size = Convert.ToInt32(Console.ReadLine());

ShowArray(size);

