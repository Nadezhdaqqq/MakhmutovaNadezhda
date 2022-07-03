//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа//
/*
int CutNumber()
{
int num;

Console. WriteLine("Input number from 100 to 999: ");
num = Convert.ToInt32(Console.ReadLine());

int ten = num / 10;

int result = ten % 10;

return result;
}



 int num = CutNumber();
 Console.WriteLine(num);

*/


//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.//

int num;
int x;
Console. WriteLine("Input number from : ");
num = Convert.ToInt32(Console.ReadLine());

while (num > 1000)
{
   x = num / 10;
   Console. WriteLine(x);
   break;
}







//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным//
/*
int Weekend()

{
int day;

Console. WriteLine("Input number from 1 to 7: ");
day = Convert.ToInt32(Console.ReadLine());

if (day == 1)
Console.WriteLine("Monday");

if (day == 2)
Console.WriteLine("Tuesday");

if (day == 3)
Console.WriteLine("Wednesday");
    
if (day == 4)
Console.WriteLine("Thursday");

if (day == 5)
Console.WriteLine("Friday");

if (day == 6)
Console.WriteLine("Saturday");

if (day == 7)
Console.WriteLine("Sunday");

    if (day == 6 || day == 7)
    Console. WriteLine("It is a weekend");

    if (day > 0 && day < 6)
    Console. WriteLine("it's a work day, sorry");

       if (day < 1 || day > 7)
       Console. WriteLine("you entered the wrong number");

return day;
    
}

int day = Weekend();
Console.WriteLine();

*/