﻿//Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

/*
int InputNum(string message) //Ввод с клавиатуры
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void PrintNumbers(int start, int end) //Вывод натуральных чисел от N до 1
{
  if (end > start) return;
  PrintNumbers(start, end + 1);
  Console.Write(end + ", ");
}

int n = InputNum("Введите N: ");
int count = 2;
PrintNumbers(n, count);
Console.Write(1);
*/

//------------------------------------------------------------------------------------------------------------------------------------

//Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int InputNum(string message) //Ввод с клавиатуры
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void PrintSumm(int m, int n, int summ) //Сумма элементов
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов = {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}

int m = InputNum("Введите M: ");
int n = InputNum("Введите N: ");
int local = m;

if (m > n) 
{
  m = n; 
  n = local;
}

PrintSumm(m, n, local=0);
*/

//------------------------------------------------------------------------------------------------------------------------------------

//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

int InputNum(string message) //Ввод с клавиатуры
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int AkkerFunc(int m, int n) //Расчет функции Аккермана
{
  if (m == 0) return n + 1;
  else if (n == 0) return AkkerFunc(m - 1, 1);
  else return AkkerFunc(m - 1, AkkerFunc(m, n - 1));
}

int m = InputNum("Введите M: ");
int n = InputNum("Введите N: ");

int functionAkkerman = AkkerFunc(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");