// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Type number of day (between 1 to 7): ");
int day = int.Parse(Console.ReadLine());

bool Fair = day < 8 &&  day > 0;

if (Fair == true){


if (day == 1)
{
    Console.WriteLine($"day of the week mumber {day} is the MONDAY and this IS NOT day off");
}

if (day == 2)
{
    Console.WriteLine($"day of the week mumber {day} is the TUESDAY and this IS NOT day off");
}

if (day == 3)
{
    Console.WriteLine($"day of the week mumber {day} is the WEDNESDAY and this IS NOT day off");
}

if (day == 4)
{
    Console.WriteLine($"day of the week mumber {day} is the THURSDAY and this IS NOT day off");
}

if (day == 5)
{
    Console.WriteLine($"day of the week mumber {day} is the FRIDAY and this IS NOT day off, but day before :)");
}

if (day == 6)
{
    Console.WriteLine($"day of the week mumber {day} is the SATURDAY and this IS day off, relax ;)");
}

if (day == 7)
{
    Console.WriteLine($"day of the week mumber {day} is the SUNDAY and this IS day off, relax ;) but tomorrow will be the MONDAY :((");
}
}
else{
    Console.WriteLine($"WTF man, you type number {day} which IS NOT the day of week!!!");
}
