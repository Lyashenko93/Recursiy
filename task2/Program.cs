﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m, n);

void AkkermanFunction(int m, int n)
{
    Console.WriteLine(AkkermanFunction(m, n));
}

int Akkerman(int m, int n)
{
    if(n == 0)
    {
        return n+1;
    }
    else if(n ==0 && n > 0)
    {
        return Akkerman(n-1, 1);
    }
    else
    {
        return Akkerman(m-1, Akkerman(m, n - 1));
    }
}
