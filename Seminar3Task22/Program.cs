// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу квадратов чисел от 1 до 
// N.

int numN = ReadConsole("Enter 1 natural number");
string outLine = LineBuilder(numN,1);
PrintResult("All natural numbers from 1 to your number", outLine);
string outLine2 = LineBuilder(numN,2);
PrintResult("Their double natural numbers from 1 to your number", outLine2);

int ReadConsole(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintResult(string msg, string res)
{
    Console.WriteLine(msg + res);
}

string LineBuilder(int numN, int pow)
{
    string line = string.Empty;
    for(int i=1; i<numN; i++)
    {
        line = line + Math.Pow(i, pow) + " ";
    }
    return line;
}
