// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

double GetNumberFromConsole()
{
    Console.WriteLine("Введите положительное число ");
    double a=Convert.ToDouble(Console.ReadLine());
    if(a<0) Console.WriteLine("ошибка, отрицательное число:" + a); 
    return a;
}

int RoundInput(double a)
{
    return Convert.ToInt32(Math.Truncate(a));
}

int max=RoundInput(GetNumberFromConsole());
Console.WriteLine("Макс = " + max);

void Descent(int a)
{
    if(a>0)
    {
        Console.Write(a + " ");
        Descent(--a);
    }
}

Descent(max);