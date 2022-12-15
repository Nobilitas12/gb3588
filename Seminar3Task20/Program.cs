// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между 
// ними в 2D пространстве.

int x1 = ReadData("Enter x coordinate 1 dot");
int y1 = ReadData("Enter y coordinate 1 dot");
int x2 = ReadData("Enter x coordinate 2 dot");
int y2 = ReadData("Enter y coordinate 2 dot");

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

double DotsLenght(double x1, double x2, double y2, double y1)
{
    double distance = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1-y2)*(y1-y2));
    return distance;
}

double res = DotsLenght(x1, y1, x2, y2);

void PrintResult(string msg, double res)
{
    Console.WriteLine(msg + res);
}

double res = DotsLenght(x1, y1, x2, y2);

PrintResult("Distance between 2 dots is " + res);