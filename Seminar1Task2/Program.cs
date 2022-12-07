string? numberA = Console.ReadLine();
if(numberA!=null)
{
    string[] weekDay = new string[7];
    weekDay[0] = "Monday";
    weekDay[1] = "Tuesday";
    weekDay[2] = "Wednesday";
    weekDay[3] = "Thursday";
    weekDay[4] = "Friday";
    weekDay[5] = "Saturday";
    weekDay[6] = "Sunday";
    int inputNumber = int.Parse(numberA);
    string weekDayprint = weekDay[inputNumber - 1];
    Console.WriteLine("Day of the week is");
    Console.WriteLine(weekDayprint);
}