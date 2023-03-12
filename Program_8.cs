/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int N;
int number = 1;

Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine()!, out N);

while (number != N + 1)
{
    if (number % 2 == 0)
        Console.Write($"{number} ");
    number = number + 1;
}