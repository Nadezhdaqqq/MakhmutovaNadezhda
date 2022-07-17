
 //Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.//
 
Console.Write($"Input М (size of array): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];


void InputNumbers(int m)
{

   for (int i = 0; i < m; i++)
     {
       Console.Write($"Input {i+1} number: ");
       array[i] = Convert.ToInt32(Console.ReadLine());
     }
}
 

int Total(int[] array)
{
int count = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0 ) count = count + 1; 
  }

return count;
}


InputNumbers(m);

Console.WriteLine("Total natural numbers is:  " + Total(array));

