// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

int num1 = new Random().Next(1,10);
int num2 = new Random().Next(10,20);
Console.WriteLine("Сген. числа");

PrintNum(num1, num2);

void PrintNum(int start, int end)
{
    if(start > end)
    {
        return;
    }
    Console.Write(start+ " ");
    PrintNum(++start, end);
}
