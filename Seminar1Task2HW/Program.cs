// №2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число 
// большее, а какое меньшее.

//Выводим текст на консоль
Console.WriteLine("Enter 2 numbers");

//Считываем число с консоли
string? numA = Console.ReadLine();
string? numB = Console.ReadLine();

//Проверяем, чтобы данные были не пустые
if(numB!=null&&numA!=null)
{
    //Парсим введенное число 
    int inputNumberA = int.Parse(numA);
    int inputNumberB = int.Parse(numB);

    //Вводим переменные для обозначения макс. и мин. чисел
    int max = inputNumberA;
    int min = inputNumberB;

    //Проверяем какое из 2 чисел наибольшее
    if(min > max)
    {
        max = inputNumberB;
        min = inputNumberA;
    }

    //Выводим данные на консоль
    Console.Write("Maximum number is " + max + "\n");
    Console.Write("Minimum number is " + min + "\n");
}