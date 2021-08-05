using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//написать метод изменяющий количество элементов массива
namespace Homework_12
{
  class Program
  {

    static void Resize(ref int[] array, char index, int count)
    {
      int[] currArray = new int[array.Length];
      for (int i = 0; i < array.Length; i++)
      {
        currArray[i] = array[i];
      }
      if (index == '+')
      {
        array =  new int [array.Length + count];
        for (int i = 0; i < currArray.Length; i++)
        {
          array[i] = currArray[i];
        }
      }
      else if (index == '-')
      {
        array =  new int[array.Length - count];
        for (int i = 0; i < array.Length; i++)
        {
          array[i] = currArray[i];
        }
      }

    }

    static void Main(string[] args)
    {
      int[] myArray = new int[] { 1, 2, 3, 4, 5 };
      foreach (var item in myArray)
      {
        Console.Write(item + " ");
      }
      Console.WriteLine();
      Console.WriteLine("+ увеличить количество элементов, - уменьшить количество элементов.");
      Console.Write("Введите, что хотите сделать с массивом чисел: ");
      char indicator = char.Parse(Console.ReadLine());
      if (indicator == '+')
      {
        Console.Write("Введите, сколько элементов хотите добавить: ");
        int count = int.Parse(Console.ReadLine());
        Resize(ref myArray, indicator, count);
      }
      else
      {
        Console.Write("Введите, сколько элементов хотите удалить: ");
        int count = int.Parse(Console.ReadLine());
        Resize(ref myArray, indicator, count);
      }
      foreach (var item in myArray)
      {
        Console.Write(item + " ");
      }
      Console.ReadLine();
    }
  }
}
