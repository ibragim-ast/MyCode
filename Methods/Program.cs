// Метод суммы чисел от 1 до А

// int Sum(int a)
// {
//     int result = 0;
//     for (int i = 0; i <= a; i++)
//     {
//         result += i;
//     }
//     return result;
// }
// void PrintSum(int a)
// {
//     if (a > 1)
//     Console.WriteLine($"Сумма чисел от 1 до {a} равна {Sum(a)}");
//     else
//     Console.WriteLine("Некорректное число для суммирования");
// }
// PrintSum(2);

// Метод вывода количества цифр в числе

// int NumberOfDigits(int number)
// {
//     int result = 0;
//     for (int i = 1; number > 0; number /= 10)
//     {
//         result = i++;
//     }
//     return result;
// }
// void PrintNumbersOfDigits(int number)
// {
//     if (NumberOfDigits(number) > 1)
//     Console.WriteLine($"В числе {number} {NumberOfDigits(number)} цифр");
//     else
//     Console.WriteLine($"В числе {number} {NumberOfDigits(number)} цифра");
// }
// PrintNumbersOfDigits(5);

// Метод произведения чисел от 1 до N

// int Multiplication(int a)
// {
//     int result = 1;
//     for (int i = 1; i <= a; i++)
//     {
//         result *= i;
//     }
//     return result;
// }
// void PrintMultiplication(int a)
// {
//     if (a > 1)
//     Console.WriteLine($"Факториал чисел от 1 до {a} равно {Multiplication(a)}");
//     else
//     Console.WriteLine("Некорректное число для произведения");
// }
// PrintMultiplication(0);

// Метод создания массива из 8 элементов, заполненный 0 и 1

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(0, 2);
//         index++;
//     }
// }
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(col[position]);
//         position++;
//         Console.Write(" ");
//     }
// }
// int[] array = new int[8];
// FillArray(array);
// PrintArray(array);

// Метод возведения числа А в натуральную степень B

// int Exponentiation(int a, int b)
// {
// int result = 1;
// for (int i = 0; i < b; i++)
// {
//     result *= a;
// }
// return result;
// }

// void PrintExponentiation (int a, int b)
// {
//     Console.WriteLine($"Число {a} в степени {b} равно {Exponentiation(a, b)}");
// }
// PrintExponentiation(3, 5);
// PrintExponentiation(2, 4);

// Метод вывода сумму цифр в числе

// int SumDigits(int number)
// {
//     int result = 0;
//     for (int i = 0; number > 0; i++)
//     {
//         result += number % 10;
//         number /= 10;
//     }
//     return result;
// }
// void PrintSumDigits(int number)
// {
//     Console.WriteLine(SumDigits(number));
// }
// PrintSumDigits(452);

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        position++;
        Console.Write(" ");
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);

