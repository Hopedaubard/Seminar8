﻿// Напишите программу, которая бы вывела числа 
// от одного до ста включительно по следующим правилам: 
// если число делится на 3, то выведите "fizz", если 
// число делится на 5, то выведите "buzz", если число 
// делится и на 3, и на 5, то выведите "fizzbuzz", 
// а если ни одно из этих условий не выполняется, 
// то выведите число как обычно.

for (int i = 1; i <= 100; i++)

{
    if (i % 3 == 0 || i % 5 == 0)
    {
        Console.Write(" fizzbuzz ");
    }

    else if (i % 5 == 0)
    {
        Console.Write(" buzz ");

    }
    else if (i % 3 == 0)
    {
        Console.Write(" fizz ");
    }
    else
    {
        Console.Write($" {i} ");
    }
}

Console.ReadLine();