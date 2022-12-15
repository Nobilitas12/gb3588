// №21 Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

double x1 = ReadConsole("Enter x coordinate of 1 dot");
double y1 = ReadConsole("Enter y coordinate of 1 dot");
double z1 = ReadConsole("Enter z coordinate of 1 dot");
double x2 = ReadConsole("Enter x coordinate of 2 dot");
double y2 = ReadConsole("Enter y coordinate of 2 dot");
double z2 = ReadConsole("Enter x coordinate of 2 dot");

double res = DotsLenght(x1,x2,y1,y2,z1,z2);
PrintResult("Distance between 2 dots in 3D is " + res);

double ReadConsole(string msg)
{
    Console.WriteLine(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}

void PrintResult(string msg, double res)
{
    Console.WriteLine(msg + res);
}

double DotsLenght(double x1, double x2, double y2, double y1, double z2, double z1)
{
    double distance = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
    return distance;
}