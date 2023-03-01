//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int number = new Random().Next(100,500);
// Console.WriteLine(number);

// int DecNumber(int num)
// {
//     int tmp = num % 100;
//     tmp = tmp / 10;
//     return tmp;
// }

// int a = DecNumber(number);
// Console.WriteLine(a);

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int CreateNumber()
// {
//     return new Random().Next(1,50000);
// }

// int a = CreateNumber();
// Console.WriteLine(a);
// if (a/100 >= 1)
// {
//     string str = a.ToString();
//     Console.WriteLine(str[2]);
// }
// else Console.WriteLine("третьей цифры нет");


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int CreateNumber(int min, int max)
{
    int a = new Random().Next(min,max+1);
    return a;
}

int day = CreateNumber(1, 7);
Console.Write(day);
if(day/5==0) 
{
Console.WriteLine(" - будний день");
}
else Console.WriteLine(" - выходной день");