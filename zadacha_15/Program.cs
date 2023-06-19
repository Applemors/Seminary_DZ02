/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да 8989
1 -> нет
*/

int Number = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(Day(Number));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
string Day(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write( a + " - Выходной");
        }
        else
        {
            Console.Write(a + " - Рабочий");
        }
    }
    else
    {
        Console.Write("Неверно выбран");
    }
    return " день.";
}