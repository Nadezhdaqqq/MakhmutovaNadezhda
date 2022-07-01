//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа//

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

