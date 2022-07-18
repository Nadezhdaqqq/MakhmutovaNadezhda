
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



/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем*/

void Point()
{
Console.Write("Input k1:   ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input b1:   ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input k2:   ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input b2:   ");
double b2 = Convert.ToInt32(Console.ReadLine());


if ((k1 == k2) && (b1 == b2))
    Console.WriteLine("Прямые совпадают");
        else if (k1 == k2)
           Console.WriteLine("Прямые паралельные");
              else
                Console.WriteLine("Координаты точки пересечения прямых: " + (b2-b1)/(k1-k2) + (k1*((b2-b1)/(k1-k2))+b1));
}

/*Point();*/












