//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.//
/*
int a;
int b;


Console. WriteLine("Input number a: ");
a=Convert.ToInt32(Console.ReadLine());

Console. WriteLine("Input number b: ");
b=Convert.ToInt32(Console.ReadLine());

if (a == b)
{
     Console.WriteLine("the numbers are equal");
}

else

  if (a > b) 
  {
   Console.WriteLine("max" + a); 
   Console.WriteLine("min" + b);
  }
 
  else
  {
   Console.WriteLine("max" + b); 
   Console.WriteLine("min" + a);
  } 

*/



//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.//
/*
int a;
int b;
int c;

Console. WriteLine("Input number a: ");
a=Convert.ToInt32(Console.ReadLine());

Console. WriteLine("Input number b: ");
b=Convert.ToInt32(Console.ReadLine());

Console. WriteLine("Input number c: ");
c=Convert.ToInt32(Console.ReadLine());

if (a > b)
   if (a > c)
    {
     Console.WriteLine("max" + a);
    }
    else
         Console.WriteLine("max" + c);
else
     if (b > c)
     {
      Console.WriteLine("max" + b);    
     }
     else
       Console.WriteLine("max" + c);    
     
*/



//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).//
/*
int num;

Console. WriteLine("Input number: ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
     Console.WriteLine("четное число");
}
else   
     Console.WriteLine("нечетное число"); 

*/



//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.//
/*
int n;
int current = 2;

Console. WriteLine("Input n: ");
n = Convert.ToInt32(Console.ReadLine());

while (current <= n)
{
   if (current % 2 == 0)
   Console.WriteLine(current);  
   current++;
}
*/