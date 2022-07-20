// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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
    if (s == e) return s;
    else return s+MultiplicationMN(s+1,e);
}