﻿// Напишите программу, которая принимает на вход число и 
// проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да



Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

void CheckIfMultiple(int a)

{
    if ((a % 7 == 0) && (a % 23 == 0)) // && – и
    {
        Console.WriteLine("Число кратно 23 и 7");
    }

    else
    {
        Console.WriteLine("Число не кратно");
    }
}

CheckIfMultiple(a);