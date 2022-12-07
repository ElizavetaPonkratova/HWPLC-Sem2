/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Например:
645 -> 5 78 -> третьей цифры нет 32679 -> 6*/

int result = 0;
Console.WriteLine("Enter number:");
int number = int.Parse(Console.ReadLine());
              

if (number >= 100)
{
    while (number > 999)
    {
        number = number /10;
    }
    result = number % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("third number is missing");
}