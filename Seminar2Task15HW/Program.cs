// №15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Enter 1 number from 1 to 7");

int numberA = int.Parse(Console.ReadLine()??"0");

string[] array = new string[7];
array[0] = "Monday";
array[1] = "Tuesday";
array[2] = "Wednesday";
array[3] = "Thursday";
array[4] = "Friday";
array[5] = "Saturday";
array[6] = "Sunday";

if(numberA<6)
{
    Console.WriteLine("Your number is the following day: "+ array[numberA-1]+ ". It isn't a weekend");
}
else
{
    Console.WriteLine("Your number is the following day: "+ array[numberA-1] + ". It is a weekend");
}