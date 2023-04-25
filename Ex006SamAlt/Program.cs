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

string GetTwoDigits (int r)
{
    string b = Convert.ToString(r);
    Console.WriteLine($"{b[0]}{b[2]}"); // сложение строк
    return b;
}


GetTwoDigits (GetThreeDigitNumber());