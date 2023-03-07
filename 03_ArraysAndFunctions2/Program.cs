// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int arrSize = 6; //количество трехзначных чисел для генерации и обработки
// int[] CreateArray()
// {
//     int[] arr = new int[arrSize];
//     for (int i = 0; i < arrSize; i++) arr[i] = new Random().Next(100,1000);
//     return arr;
// }

// int[] mass = CreateArray();
// for (int i = 0; i < arrSize; i++) 
// {
// Console.Write(mass[i]);
// Console.Write(' ');
// }
// Console.WriteLine();
// Console.WriteLine("Из них четные: ");

// for (int i = 0; i < arrSize; i++) 
// {
//     if (mass[i]%2==0)
//     {
//     Console.Write(mass[i]);
//     Console.Write(' ');
//    }
// }

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int arrSize = 6; //количество трехзначных чисел для генерации и обработки
// int[] CreateArray()
// {
//     int[] arr = new int[arrSize];
//     for (int i = 0; i < arrSize; i++) arr[i] = new Random().Next(100,1000);
//     return arr;
// }

// int[] mass = CreateArray();
// for (int i = 0; i < arrSize; i++) 
// {
// Console.Write(mass[i]);
// Console.Write(' ');
// }
// Console.WriteLine();
// Console.WriteLine("Из них на нечетных позициях: ");

// int sum = 0;
// for (int i = 0; i < arrSize; i++) 
// {
//     if ((i+1)%2 != 0)
//     {
//     Console.Write(mass[i]);
//     Console.Write(' ');
//     sum += mass[i];
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int arrSize = 6; //количество трехзначных чисел для генерации и обработки
int[] CreateArray()
{
    int[] arr = new int[arrSize];
    for (int i = 0; i < arrSize; i++) arr[i] = new Random().Next(100,1000);
    return arr;
}

int[] mass = CreateArray();
for (int i = 0; i < arrSize; i++) 
{
Console.Write(mass[i]);
Console.Write(' ');
}

int min = mass[0];
int max = mass[0];
for (int i = 1; i < arrSize; i++) 
{
    if (mass[i] < min) min = mass[i];
    if (mass[i] > max) max = mass[i];    
}
Console.WriteLine();
Console.WriteLine("Минимальный элемент: " + min);
Console.WriteLine("Максимальный элемент: " + max);
Console.WriteLine("Разница между ними: " + (max-min));