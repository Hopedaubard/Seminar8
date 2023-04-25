// Напишите программу, которая выводит случайное число из отрезка 
// [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int rand = new Random().Next(10, 100); // диапазон рандомного числа от 10 до 99
Console.WriteLine("Рандомное число: "+ rand);
int num01 = rand/10; // 1 цифра рандомного числа
int num02 = rand%10; // последняя цифра рандомного числа
FindLargestNumber(num01, num02);

int rand1 = new Random().Next(10, 100); // диапазон рандомного числа от 10 до 99
Console.WriteLine("Рандомное число: "+ rand1);
int num03 = rand1/10; // 1 цифра рандомного числа
int num04 = rand1%10; // последняя цифра рандомного числа
FindLargestNumber(num03, num04);

void FindLargestNumber(int num1, int num2)
{
    if (num1 > num2){
        Console.WriteLine("Наибольшая цифра числа: " + num1);
    }
    else if (num1 < num2)
    {
        Console.WriteLine("Наибольшая цифра числа: " + num2);
    }
    else{
        Console.WriteLine("Числа равны");
    }
}