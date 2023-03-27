//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7  min = 5
//a = 2 b = 10 -> max = 10  min = 2
//a = -9 b = -3 -> max = -3  min = -9

// Вводим любые два целых числа.
System.Console.WriteLine("Введите два числа");
int a = 0;
int b = 0;
int max = 0;
int min = 0;

// TryParse проверяет цифры это или нет, если нет, выдает "OOps". Если да, выполняется действия с цифрами.

if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b))
{
    // В цикле идет сравнение дыух чисел какое больше, а какое меньше, меньшему присваивается переменная min
    // наибольшему присваивается max и выводится в Console.
    if (a > b)
    {
        max = a;
        min = b;
        Console.WriteLine("Min: {0}", min);
        Console.WriteLine("Max: {0}", max);
    }
    else if (a < b)
    {
        max = b;
        min = a;
        Console.WriteLine("Min: {0}", min);
        Console.WriteLine("Max: {0}", max);
    }
}
else
{
    Console.WriteLine("OOps");
}
