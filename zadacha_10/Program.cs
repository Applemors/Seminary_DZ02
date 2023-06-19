/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/


Random rand = new Random();
int number = new Random().Next (100,1000);
int firstNum = number / 100;
int secNum = number % 10;
int thirdNum = number / 10;
int result = ((number - (firstNum*100)) / 10);
Console.Write($"{number} - Полученное число ;");
Console.Write($" {result} - Выделенная цифра");

