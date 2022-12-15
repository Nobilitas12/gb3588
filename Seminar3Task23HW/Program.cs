// №23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N.1


int numN = ReadConsole("Enter 1 natural number");
string outLine = LineBuilder(numN,1);
PrintResult("All natural numbers from 1 to your number are ", outLine);
string outLine2 = LineBuilder(numN,3);
PrintResult("Their triple multiplications are ", outLine2);

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
    line = line + Math.Pow(numN,pow);
    return line;
}