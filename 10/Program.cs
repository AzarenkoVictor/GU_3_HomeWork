﻿// Задача 10: Напишите программу, которая 
// принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введи трехначное число");
string a = Console.ReadLine();
int dl = a.Length;
int b = Convert.ToInt32(a);

if (dl == 3)
{
    int ch2 = (b / 10) % 10;
    Console.WriteLine("Второй цифрой числа " + b + " является " + ch2);
}
else
    Console.WriteLine("Не пытайся обмануть систему, ты ввел " + dl + " значное число !");
