//  Напишите программу, которая на вход принимает число (N), а на выходе показывает 
// все чётные числа от 1 до N.

//Выводим текст на консоль
Console.WriteLine("Enter 1 natural number");

//Считываем число с консоли
string? numA = Console.ReadLine();

//Проверяем, чтобы данные были не пустые
if(numA!=null)
{
    //Парсим введенное число 
    int inputNumber = int.Parse(numA);
    
    //Вводим стартовое число
    int startNumber = 1;

    //Выходное значение
    string outLine = string.Empty;

    while(startNumber < inputNumber)
    {
        if((startNumber % 2) == 0)
        {
            outLine = outLine + startNumber + ", ";
        }
        startNumber++;
    }
    if((inputNumber%2) == 0)
    {
        outLine = outLine + inputNumber;
    }

    //Выводим данные в консоль
    Console.WriteLine("All even numbers from 1 to your numbers are " + outLine);
}