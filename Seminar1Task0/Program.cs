// Задача №0 
// Напишите программу, которая на вход принимает 
// число и выдаёт его квадрат (число умноженное на 
// само себя).
string? num1line = Console.ReadLine();
string? num2line = Console.ReadLine();

if(num1line!=null&&num2line!=null)
{
    int num1 = int.Parse(num1line);
    int num2 = int.Parse(num2line);
    int result = num1*num2;

    Console.WriteLine(result);
}
