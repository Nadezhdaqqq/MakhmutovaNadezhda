
int Quantity (int n)
{
if (n / 10 !=0)
{
    return 1 + Quantity(n / 10);
}
else return 1;

}

int Sum (int m, int n)
{ 

if (m < n)
{
    return m = m + Sum(m+1, n);
}
else return m;

}


//Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.//
/*
Console.Write("Input n:   ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Quantity of digits in a number:  " +  Quantity(n));
*/


//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.//
/*
Console.Write("Input m:   ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input n:   ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Sum from m to n:  " + Sum(m, n));
*/