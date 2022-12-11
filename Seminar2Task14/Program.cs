Console.WriteLine("Enter 1 number");

int numberA = int.Parse(Console.ReadLine()??"0");

int result7 = numberA%7;
int result23 = numberA%23;

if(result7==0&&result23==00)
{
    Console.WriteLine("Number is a multiple number to numbers 7 and 23");
}
else
{
   Console.WriteLine("Number is not a multiple number to numbers 7 and 23"); 
}