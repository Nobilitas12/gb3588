//Создаем экземпляр класса рандомайзер
System.Random numberSyntezator = new System.Random();

//Получаем новое случайное число
int number = numberSyntezator.Next(10,100);

//Выводим данные в консоль
Console.WriteLine(number);

//Получаем первое и число по отдельности
int firstNumber = number/10;
int secondNumber = number%10;

//Сравниваем числа
if(firstNumber>secondNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(secondNumber);
}
//2 вариант
// char[] digits = numberSyntezator.Next(10,100).ToString().ToCharArray();
// Console.WriteLine(digits);

// int firstNumber = ((int)digits[0])-48;
// int secondNumber = ((int)digits[1])-48;

// int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;
// Console.WriteLine(resultNumber);