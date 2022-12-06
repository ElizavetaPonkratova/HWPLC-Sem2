/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Например:
456 -> 5 782 -> 8 918 -> 1*/

Random random = new Random();
int randomNumber = random.Next(99, 1000);

Console.WriteLine(randomNumber);
Console.WriteLine(randomNumber / 10 % 10);