// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите 1-е число = ");
string numbers1String = Console.ReadLine()!;
int numbers1Int = Convert.ToInt32(numbers1String);
Console.Write("Введите 2-е число = ");
string numbers2String = Console.ReadLine()!;
int numbers2Int = Convert.ToInt32(numbers2String);

if(numbers1Int > numbers2Int)
{
    Console.WriteLine($"max = {numbers1Int}");
}
else
{
   Console.WriteLine($"max = {numbers2Int}");
}
