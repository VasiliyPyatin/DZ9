// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

using System;
using static System.Console;

Clear();

WriteLine("Введите число M: ");
int m = int.Parse(ReadLine());
WriteLine("Введите число N: ");
int n = int.Parse(ReadLine());

Write($"A(m,n) = {FunctionAkkerman (m, n)} ");

int FunctionAkkerman(int a, int b)
{
    if (a == 0) return b + 1;
    if (a != 0 && b == 0) return FunctionAkkerman(a - 1, 1);
    else return FunctionAkkerman(a - 1, FunctionAkkerman(a, b - 1));
    
}