// Напишите программу, которая будет 
// принимать на вход два числа и выводить, 
// является ли второе число кратным 
// первому. Если второе число некратно 
// первому, то программа выводит о статок 
// от деления .


Console.WriteLine("Enter 2 numbers");

int numberA = int.Parse(Console.ReadLine()??"0");
int numberB = int.Parse(Console.ReadLine()??"0");

int result = numberB%numberA;

if(result==0)
{
    Console.WriteLine("Number 2 is a multiple number to number 1");
}
else
{
   Console.WriteLine("Number 2 is not a multiple number to number 1. Resedue is " + result); 
}