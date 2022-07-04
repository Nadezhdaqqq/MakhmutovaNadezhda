//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N//
/*
void Cube(int n)
{
  
int current = 1;

while (n >= current) 
{ int cube = current*current*current;
  Console.Write(cube + "   ");
  current++;    
}

}



Console.WriteLine("Input num");
int n = Convert.ToInt32(Console.ReadLine());

Cube(n);
*/

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.//
void Palindrome()
{
Console.WriteLine("Input a   ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input b   ");
int b = Convert.ToInt32(Console.ReadLine());

if (a < 10000 || a >= 100000 || b < 10000 || b >= 100000)
Console.WriteLine("You entered the wrong number");

else
{

    if ((a / 10000) == (b % 10))
        {
          if ((a % 100 / 10) == (b / 1000 % 10))
        Console.WriteLine("Palindrome");
        }
    else
    {   
    Console.WriteLine("Not palindrome");
    }
}

}


Palindrome();


