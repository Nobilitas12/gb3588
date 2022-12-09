//Выводим текст на консоль
Console.WriteLine("Enter 1 number");

//Считываем число с консоли
string? numA = Console.ReadLine();

//Проверяем, чтобы данные были не пустые
if(numA!=null)
{
    //Парсим введенное число 
    int inputNumberA = int.Parse(numA);

    //Вводим переменную для обозначения осатка от деления
    int residue = inputNumberA % 2;

    //Проверяем равен ли остаток нулю и выводим данные на консоль
    if(residue == 0)
        Console.WriteLine("The number is even");
    else
        Console.WriteLine("The number is odd");
}