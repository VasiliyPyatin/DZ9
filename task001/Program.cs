// Решение только через рекурсию!

// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет произведение натуральных чисел в промежутке от M до N.

// M = 1; N = 5. ->120

// M = 4; N = 6. -> 120

using System;
using static System.Console;

Clear();

WriteLine("Введите стартовое значение M: ");
int m = int.Parse(ReadLine());
WriteLine("Введите конечное значение N: ");
int n = int.Parse(ReadLine());

if (m > n) 
{
  int temp = m;
  m = n; 
  n = temp;
}

WriteLine(MultiplicationMN (m, n));

int MultiplicationMN (int s, int e)
{
    if (s <= e) return s*MultiplicationMN(s+1,e);
    if (s == 0) return 0;
    else return 1;
}