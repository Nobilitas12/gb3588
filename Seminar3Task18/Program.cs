// Напишите программу, которая по заданному номеру 
// четверти, показывает диапазон возможных 
// координат точек в этой четверти (x и y).

int quarterNumber = ReadData("Enter quarter number");

PrintAnswer();

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintAnswer()
{
    if (quarterNumber == 1) Console.WriteLine("X > 0, Y > 0");

    if (quarterNumber == 2) Console.WriteLine("X > 0, Y < 0");

    if (quarterNumber == 3) Console.WriteLine("X < 0, Y < 0");

    if (quarterNumber == 4) Console.WriteLine("X < 0, Y > 0");
}