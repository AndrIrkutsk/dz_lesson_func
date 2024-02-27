// Задача 3: Напишите программу, которая перевернёт одномерный 
// массив (первый элемент станет последним, второй – предпоследним и т.д.)

using System;

class Program
{
  static void Main()
  {
    TurningArray();
  }

  static void TurningArray() 
  {
    Console.WriteLine("Введите числа через запятую: ");
    string inputArray = (Console.ReadLine()!);

    string[] substrings = inputArray.Split(',');
    int[] arrReverse = ReverseArray(substrings);
    PrintArray(arrReverse);
    
    // PrintArray(ReverseArray(substrings));
  }

  static int[] ReverseArray(string[] stringArray)
  {
    int[] reverseArray = new int[stringArray.Length];

    for (int i = 0; i < stringArray.Length; i++)
    {
      reverseArray[reverseArray.Length - (1 + i)] = int.Parse(stringArray[i]);
    }

    return reverseArray;
  }

  static void PrintArray(int[] array) 
  {
    for (int i = 0; i < array.Length; i++)
    {
      Console.Write($"{array[i]} ");
    }
  }
}