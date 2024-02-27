// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
using System;

class Program
{
  static void Main()
  {
    GetStart();
  }

  static void GetStart() {
    Console.WriteLine("Введите размер массива (целое число): ");
    int lenArray = int.Parse(Console.ReadLine()!);
    int[] randomArray = new int[lenArray];

    PrintResult("---");

    for (int i = 0; i < lenArray; i++)
    {
      randomArray[i] = new Random().Next(100, 1000);
      PrintResult($"{randomArray[i]} ");
    }

    int countEven = GetCountEvenElmInArray(randomArray);
    PrintResult($"Количество чётных элементов в массиве: {countEven}");
  }

  static int GetCountEvenElmInArray(int[] array) {
    int count = 0;

    foreach (var elm in array)
    {
      if(elm % 2 == 0) {
        count++;
      }
    }

    return count;
  }

  static void PrintResult(string result) {
    Console.WriteLine(result);
  }

}