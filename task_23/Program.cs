// Задача 23: Напишите программу, которая 
// принимает на вход число (N) и выдает 
// таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine()!);
int count = 1;
int cou = 0;
while (count <= N)
{
    cou = count * count * count;
    Console.Write(cou);
    if (count < N)
    {
        Console.Write(", ");
    }
    count ++;
}

