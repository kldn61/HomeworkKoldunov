// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите a = ");
int a = int.Parse(Console.ReadLine()!);

// int i = 0;
// int sum = 0;

int len = Length(a);
Console.WriteLine($"Сумма цифр в числе {a} равно: {Sum(a,len)}");

int Length(int a)
{
int index = 0;
while (a > 0)
{
a /= 10;
index++;
}
return index;
}

int Sum(int a, int len)
{
int sum = 0;
for (int i = 1; i <= len; i++)
{
sum += a % 10;
a /= 10;
}
return sum;
}