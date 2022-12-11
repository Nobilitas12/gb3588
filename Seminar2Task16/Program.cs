void Test (int i, int j)
{
    bool result = (i/j==j);
    if(result==true) Console.WriteLine("Number "+i+" is a square of number "+j);
    else Console.WriteLine("Number "+i+" is not a square of number "+j);
}

Console.WriteLine("Enter 2 numbers");

int numberA = int.Parse(Console.ReadLine()??"0");
int numberB = int.Parse(Console.ReadLine()??"0");

Test(numberA, numberB);
Test(numberB, numberA);