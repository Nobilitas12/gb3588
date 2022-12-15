// №19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

int numN = ReadConsole("Enter natural number with 5 digits");
PalindromDetector(numN);

int ReadConsole(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PalindromDetector(int numN)
{
    char[] digits = numN.ToString().ToCharArray();
    if(digits[0]==digits[4]&&digits[1]==digits[3])
    {
        Console.WriteLine("This number is a palindrom");
    }
    else
    {
        Console.WriteLine("This number is not a palindrom");
    }
}