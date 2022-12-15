// Напишите программу, которая выводит 
// случайное трёхзначное число и удаляет 
// вторую цифру этого числа.

//Создаем экземпляр класса рандомайзер
System.Random numberSyntezator = new System.Random();

//Получаем новое случайное число
int number = numberSyntezator.Next(100,1000);

//Выводим данные в консоль
Console.WriteLine(number);

//int firstNumber = number/100;
//int secondNumber = number%10;

int result = (number/100)*10 + number%10;
Console.WriteLine(result);