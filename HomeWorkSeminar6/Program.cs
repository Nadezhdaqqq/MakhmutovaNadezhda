
 //Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.//
 /*
Console.Write($"Input М (size of array): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
*/
/*
void InputNumbers(int m)
{

   for (int i = 0; i < m; i++)
     {
       Console.Write($"Input {i+1} number: ");
       array[i] = Convert.ToInt32(Console.ReadLine());
     }
}
 */
/*
int Total(int[] array)
{
int count = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0 ) count = count + 1; 
  }

return count;
}
*/
/*
InputNumbers(m);

Console.WriteLine("Total natural numbers is:  " + Total(array));
*/


/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем*/

/*double[] crossPoint = new double[2];
double[,] coeff = new double[2, 2];

void InputCoefficients()
{
  
  for (int i = 0; i < coeff.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < coeff.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      coeff[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] coeff)
{
  crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
  return crossPoint;
}

void OutputResponse(double[,] coeff)
{
  if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
  {
    Console.Write("Прямые совпадают");
  }
  else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
  {
    Console.Write("Прямые параллельны");
  }
  else 
  {
    Decision(coeff);
    Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputCoefficients();
OutputResponse(coeff);
*/

double [] Double (double x, double y)
{
    double [] newArray = new double [2];
  

return newArray;
}

void ShowDoubleArray (double [] array)
{
   for (int i = 0; i < array.Length; i++)
   Console.Write(array [i]+ "   ");

   Console.WriteLine();

}


Console.Write("Input k1:   ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input b1:   ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input k2:   ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input b2:   ");
double b2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 -b1)/(k1 - k2);
double y = k1*x + b1;

if ((k1 == k2) && (b1 == b2))
      Console.WriteLine("Прямые совпадают");

else if (k1==k2)
    Console.WriteLine("Прямые параллельны");

else
Console.Write(x);
Console.Write(y);




