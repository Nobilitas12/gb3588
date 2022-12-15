// Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
// выдаёт номер четверти плоскости, в которой 
// находится эта точка.

// Console.WriteLine("Enter coordinate 1");
// int coordx = int.Parse(Console.ReadLine()??"0");
// Console.WriteLine("Enter coordinate 2");
// int coordy = int.Parse(Console.ReadLine()??"0");

// if(coordx>0&&coordy>0) Console.WriteLine("Dot is in the first quadrant");

// if(coordx>0&&coordy<0) Console.WriteLine("Dot is in the second quadrant");

// if(coordx<0&&coordy<0) Console.WriteLine("Dot is in the third quadrant");

// if(coordx<0&&coordy>0) Console.WriteLine("Dot is in the forth quadrant");

// Более оптимальный метод

int coordx = ReadData("Enter coordinate X");
int coordy = ReadData("Enter coordinate Y");
PrintDataQuarter();

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintDataQuarter()
{
    if (coordx > 0 && coordy > 0) Console.WriteLine("Dot is in the first quadrant");

    if (coordx > 0 && coordy < 0) Console.WriteLine("Dot is in the second quadrant");

    if (coordx < 0 && coordy < 0) Console.WriteLine("Dot is in the third quadrant");

    if (coordx < 0 && coordy > 0) Console.WriteLine("Dot is in the forth quadrant");
}