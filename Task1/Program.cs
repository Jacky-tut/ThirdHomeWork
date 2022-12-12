/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()??"");
number = Math.Abs(number);
string numberStr = Convert.ToString(number);

if(numberStr[0] == numberStr[4] && numberStr[1] == numberStr[3])
Console.WriteLine("Да, это палиндром");
else
Console.WriteLine("Нет, это не палиндром");