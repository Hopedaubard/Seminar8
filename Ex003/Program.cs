// Напишите программу, которая выводит случайное число из отрезка 
// [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

Main();

void Main()
{
    int rand = new Random().Next(10, 100); // диапазон рандомного числа от 10 до 99
    Console.WriteLine("Рандомное число: " + rand);
    int num01 = FirstDigitNumber(rand); // 1 цифра рандомного числа
    int num02 = SecondDigitNumber(rand); // последняя цифра рандомного числа
    FindLargestNumber(num01, num02);

    int rand1 = new Random().Next(10, 100); // диапазон рандомного числа от 10 до 99
    Console.WriteLine("Рандомное число: " + rand1);
    int num03 = FirstDigitNumber(rand1); // 1 цифра рандомного числа
    int num04 = SecondDigitNumber(rand1); // последняя цифра рандомного числа
    FindLargestNumber(num03, num04);
}

void FindLargestNumber(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.WriteLine("Наибольшая цифра числа: " + num1);
    }
    else if (num1 < num2)
    {
        Console.WriteLine("Наибольшая цифра числа: " + num2);
    }
    else
    {
        Console.WriteLine("Числа равны");
    }
}

int FirstDigitNumber(int firstNum) // поиск первого значения числа
{
    int result = firstNum / 10;
    return result;
}

int SecondDigitNumber(int secondNum) // поиск второго значения числа
{
    int result = secondNum % 10;
    return result;
}