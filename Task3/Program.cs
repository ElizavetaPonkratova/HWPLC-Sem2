/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Например: 6 -> да 7 -> да 1 -> нет*/

Console.WriteLine("Enter number day week:");
int numberDay = int.Parse(Console.ReadLine());

if ((numberDay >0) && (numberDay < 8))
{
    if (numberDay >= 6)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}
else
{
    Console.WriteLine("There is no such day of the week!");
}