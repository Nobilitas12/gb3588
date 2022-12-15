// №13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет

Console.WriteLine("Enter 1 number");

int numberA = int.Parse(Console.ReadLine()??"0");

if (numberA<99)
{
    Console.WriteLine("There is no thrid charter in this number");
}
else
{
    char[] digits = numberA.ToString().ToCharArray();
    Console.WriteLine("The third charter of this number is " + digits[2]);
}