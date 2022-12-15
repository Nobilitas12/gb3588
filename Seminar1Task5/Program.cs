// Задача №5 
// Напишите программу, которая на вход принимает 
// одно число (N), а на выходе показывает все целые 
// числа в промежутке от -N до N.

//Считываем число с консоли
string? numN = Console.ReadLine();

//Проверяем, чтобы данные были не пустые
if(numN!=null)
{
    //Парсим введенное число 
    int inputNumber = int.Parse(numN);

    int startNumber = inputNumber*(-1);

    //Выходное значение
    string outLine = string.Empty;

    while(startNumber < inputNumber)
    {
        outLine = outLine + startNumber + ", ";
        startNumber++;
    }
    outLine = outLine + inputNumber;

    //Выводим данные в консоль
    Console.WriteLine(outLine);
}