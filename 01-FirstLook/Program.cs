Console.WriteLine("Ищем максимум");
Console.WriteLine("Введите 1 число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max) max = b;
Console.Write("Максимум: ");
Console.WriteLine(max);
