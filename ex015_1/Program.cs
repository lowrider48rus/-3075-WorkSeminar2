// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//вариант 2 - попроще

Console.WriteLine("Type number of day (between 1 to 7): ");
int day = int.Parse(Console.ReadLine());

if ((day >=6) && (day <= 7)){
    Console.WriteLine($"day of the week mumber {day} IS the day off, relax ;)");
}

else{
    Console.WriteLine($"WTF man, you type number {day} which IS NOT the day off!!!");
}
