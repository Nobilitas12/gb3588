// №10 Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

//Создаем экземпляр класса рандомайзер
System.Random numberSyntezator = new System.Random();

//Получаем новое случайное число
int number = numberSyntezator.Next(100,1000);

//Выводим данные в консоль
Console.WriteLine("New random number is " + number);

Console.WriteLine("Second charter  of the number is " + (number/10)%10);