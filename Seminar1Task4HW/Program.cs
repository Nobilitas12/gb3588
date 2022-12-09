//Выводим текст на консоль
Console.WriteLine("Enter 3 numbers");

//Считываем число с консоли
string? numA = Console.ReadLine();
string? numB = Console.ReadLine();
string? numC = Console.ReadLine();

//Проверяем, чтобы данные были не пустые
if(numB!=null&&numA!=null&&numC!=null)
{
    //Парсим введенное число 
    int inputNumberA = int.Parse(numA);
    int inputNumberB = int.Parse(numB);
    int inputNumberC = int.Parse(numC);

    //Вводим переменную для обозначения макс. числа
    int max = inputNumberA;

    //Проверяем какое из 3 чисел наибольшее
    if(inputNumberB > max)
    {
        max = inputNumberB;
    }

    if(inputNumberC > max)
    {
        max = inputNumberC;
    }
    //Выводим данные на консоль
    Console.Write("Maximum number is " + max);
}