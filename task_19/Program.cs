// Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет 
// 23432 -> да
// 12821 -> да 

Console.Clear();

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);

int x1 = 99999;
int x2 = 10000; 

if (number < 0)
{   
    number = number * -1;
    if (number > x1 && number < x2)
    {
        Console.WriteLine("Нужно ввести пятизначное число!");
    }
    else
    {
        x1 = number / x2;
        x2 = number % 10;
        if (x1 != x2)
        Console.WriteLine($"Число {number} не является полиндромом");
        else
        Console.WriteLine($"Число {number} является полиндромом");
    }
}
else
{
        if (number > x1 && number < x2)
    {
        Console.WriteLine("Нужно ввести пятизначное число!");
    }
    else
    {
        x1 = number / x2;
        x2 = number % 10;
        if (x1 != x2)
        Console.WriteLine($"Число {number} не является полиндромом");
        else
        Console.WriteLine($"Число {number} является полиндромом");
    }
}
