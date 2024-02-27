// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа 
// с консоли. Программа завершается при вводе символа ‘q’ или при вводе 
// числа, сумма цифр которого чётная.
using System;

class Program
{
  static void Main()
  {
    GetSumInput();
  }

  static void GetSumInput() {
    while (true)
    {
      string getEnterUser = GetEnterUser();
      int sumNumber = 0;
      bool isNum = int.TryParse(getEnterUser, out int number);

      if(getEnterUser == "q") 
      {
        break;
      }

      if (isNum)
      {
        sumNumber = GetSumNumber(number);
        bool isParity = ParityCheck(sumNumber);

        if(isParity) {
          Console.WriteLine($"Сумма элементов чётная и равна {sumNumber}");
          break;
        }
      }
    }
  }

  static string GetEnterUser() {
    Console.WriteLine("Введите целое число: ");
    string enter = (Console.ReadLine()!);
    return enter;
  }

  static int GetSumNumber(int number) {
    int sum = 0;

    while (number != 0)
    {
      sum += number % 10;
      number = number / 10;
    }

    return sum;
  }

  static bool ParityCheck(int sumNumber) {
    return sumNumber % 2 == 0;
  }
}