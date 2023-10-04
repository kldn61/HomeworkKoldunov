// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт
// максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.Write("Введите 1-е число = ");
string aString = Console.ReadLine()!;
int aInt = Convert.ToInt32(aString);
Console.Write("Введите 2-е число = ");
string bString = Console.ReadLine()!;
int bInt = Convert.ToInt32(bString);
Console.Write("Введите 3-е число = ");
string cString = Console.ReadLine()!;
int cInt = Convert.ToInt32(cString);

if(aInt > bInt && aInt > cInt)
{
    Console.WriteLine($"max = {aInt}");
}
else if(bInt > aInt && bInt > cInt)
{
    Console.WriteLine($"max = {bInt}");
}
else if(cInt > aInt && cInt > bInt)
{
    Console.WriteLine($"max = {cInt}");
}
else
{
    Console.WriteLine($"Два числа равны {aInt == bInt || aInt == cInt || bInt == cInt}");
}
