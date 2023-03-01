//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//Console.WriteLine("Ищем максимум");
//Console.WriteLine("Введите 1 число");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите 2 число");
//int b = Convert.ToInt32(Console.ReadLine());
//int max = a;
//if (b > max) max = b;
//Console.Write("Максимум: ");
//Console.WriteLine(max);

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
//Console.WriteLine("Введите число:");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Четность: ");
//Console.WriteLine(a%2==0);

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int upper = a;
int current = 2;
if (a%2==1) upper = a-1;
while (current < upper + 1)
{
Console.Write(current);
Console.Write(' ');
current = current + 2;
}
