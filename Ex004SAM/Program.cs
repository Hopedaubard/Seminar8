// Напишите программу, которая выводит случайное трехзначное число и 
// удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

int GetThreeDigitNumber()
{
    int rand = new Random().Next(100, 1000);
    Console.WriteLine(rand);
    return rand;
}

int DeleteSecondDigit (int r)
{
    int digit_1 = r/100;
    int digit_2 = r%10;
    int second_digit = digit_1*10 + digit_2;
    Console.WriteLine("Искомое число: " + second_digit);
    return second_digit;
}

int rand = GetThreeDigitNumber();

DeleteSecondDigit(rand);