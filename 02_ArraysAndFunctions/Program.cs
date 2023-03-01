//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = new Random().Next(100,500);
Console.WriteLine(number);

int DecNumber(int num)
{
    int tmp = num % 100;
    tmp = tmp / 10;
    return tmp;
}

int a = DecNumber(number);
Console.WriteLine(a);