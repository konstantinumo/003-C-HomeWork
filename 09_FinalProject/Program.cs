// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// double GetNumberFromConsole()
// {
//     Console.WriteLine("Введите положительное число ");
//     double a=Convert.ToDouble(Console.ReadLine());
//     if(a<0) Console.WriteLine("ошибка, отрицательное число:" + a); 
//     return a;
// }

// int RoundInput(double a)
// {
//     return Convert.ToInt32(Math.Truncate(a));
// }

// int max=RoundInput(GetNumberFromConsole());
// Console.WriteLine("Макс = " + max);

// void Descent(int a)
// {
//     if(a>0)
//     {
//         Console.Write(a + " ");
//         Descent(--a);
//     }
// }

// Descent(max);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

double GetNumberFromConsole()
{
    double a=Convert.ToDouble(Console.ReadLine());
    return a;
}

int RoundInput(double a)
{
    return Convert.ToInt32(Math.Truncate(a));
}

Console.WriteLine("Введите первую границу диапазона (положительное число) ");
int min=RoundInput(GetNumberFromConsole());

Console.WriteLine("Введите вторую границу диапазона (положительное число) ");
int max=RoundInput(GetNumberFromConsole());

if(min>max)
{
    int temp=max;
    max=min;
    min=temp;
}

Console.WriteLine("Мин = " + min);
Console.WriteLine("Макс = " + max);

int curr=min;
int sum=0;
if(min>0 && max>0)
{
    while(curr<=max) 
    {
    sum=sum+curr;
    curr++;    
    }
    Console.WriteLine("Сумма = " + sum);
}
    else Console.WriteLine("ошибка, отрицательное число");

