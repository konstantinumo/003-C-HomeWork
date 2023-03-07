// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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
Console.WriteLine();
Console.WriteLine("Из них четные: ");

for (int i = 0; i < arrSize; i++) 
{
    if (mass[i]%2==0)
    {
    Console.Write(mass[i]);
    Console.Write(' ');
    }
}