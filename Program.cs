// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
System.Console.WriteLine("введите число a");
int numberA=Convert.ToInt32(Console.ReadLine()); //получение значения от терминала
System.Console.WriteLine("введите число b");
int numberB=Convert.ToInt32(Console.ReadLine()); //получение значения от терминала
int max = numberA;
if (numberA>max) max = numberA;
else max=numberB;
Console.WriteLine("max=" +max);
