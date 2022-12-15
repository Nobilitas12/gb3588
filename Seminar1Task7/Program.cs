// Задача №7 
// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе 
// показывает последнюю цифру этого числа.


//Считываем число с консоли
string? numB = Console.ReadLine();

//Проверяем, чтобы данные были не пустые
if(numB!=null)
{
    //Парсим введенное число 
    int inputNumber = int.Parse(numB);

    int lastDigit = inputNumber % 10;

    Console.WriteLine(lastDigit);
}


