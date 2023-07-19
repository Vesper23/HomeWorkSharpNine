//Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

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