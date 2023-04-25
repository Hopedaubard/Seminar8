// Напишите программу, которая будет принимать на вход два 
// числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток 
// от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

void CheckMultiple(int a, int b)
{
    if (a % b == 0)
    {
        Console.WriteLine("Первое число кратно второму");
    }

    else
    {
        Console.WriteLine("Числа не кратные. Остаток равен: " + a % b);
    }
}
CheckMultiple(a, b);