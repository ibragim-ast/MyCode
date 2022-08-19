// Метод суммы чисел от 1 до А

int Sum(int a)
{
    int result = 0;
    for (int i = 0; i <= a; i++)
    {
        result += i;
    }
    return result;
}

void PrintSum(int a)
{
    Console.WriteLine($"Сумма чисел от 1 до {a} равна {Sum(a)}");
}

PrintSum(7);


