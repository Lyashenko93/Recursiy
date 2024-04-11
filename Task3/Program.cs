// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

Console.WriteLine("Введите число");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

Console.Write("Исходный массив");
Console.WriteLine();
PrintArray();

Console.WriteLine();

Console.Write("Реверсив массива");
PrintArrayReverse(array, array.Length - 1);
Console.WriteLine();




int[] FillingArray()
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random(). Next(1,10);
    }
    return array;
}

void PrintArray()
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ ",");
    }
}

void PrintArrayReverse(int[] array, int index)
{
    if(index >= 0)
    {
        return;
    }
    Console.Write(array[index]+ " ");
    PrintArrayReverse(array, index - 1);
}

FillingArray();
PrintArray();

// Второй массив не выводится