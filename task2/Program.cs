﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


Console.WriteLine("Введите число");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m, n);

void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n));
}

int Akkerman(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if(n == 0 && m > 0)
    {
        return Akkerman (m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}