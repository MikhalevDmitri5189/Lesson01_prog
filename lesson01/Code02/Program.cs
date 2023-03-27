//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Вводим любые три целых числа.

System.Console.WriteLine("Введите три числа");
int a = 0;
int b = 0;
int c = 0;
int max = 0;

// TryParse проверяет цифры это или нет, если нет, выдает "OOps". Если да, выполняется действия с цифрами.

if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b) && int.TryParse(Console.ReadLine(), out c))
{
    // В цикле проходит сравнение трёх чисел начиная с первой переменной, при сравнений если одна переменная больше другой
    // то она переходи в переменную "max", после всех сравнений в "max" попадае самое максимальное число и выводится в Console.
    if (a > max)
    {
        max = a;
    }
    if (b > max)
    {
        max = b;
    }
    if (c > max)
    {
        max = c;
    }
    Console.WriteLine("Max: {0}", max);
}

else
{
    Console.WriteLine("OOps");
}