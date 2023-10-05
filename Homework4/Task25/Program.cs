// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите A = ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите B = ");
int B = int.Parse(Console.ReadLine()!);

int i =0;
int result = 1;
while(i < B)
{
    result *= A;
    i++;
}
Console.WriteLine(result);
