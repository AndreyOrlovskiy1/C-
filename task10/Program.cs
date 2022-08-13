// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введи трёхзначное число: ");
int numbers = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(numbers);
Console.WriteLine("вторая цифра числа - "+stringNumber[1]);