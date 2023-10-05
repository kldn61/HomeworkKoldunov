// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число n = ");
int n = int.Parse(Console.ReadLine()!);
int index = 0;

if(n < 100)
{
    Console.WriteLine("третьей цифры нет");
}
while(index < n)
{
    if(n >= 100 && n < 1000)
    {
        Console.WriteLine(n % 10);
    }
n = n /10;
index++;
}

