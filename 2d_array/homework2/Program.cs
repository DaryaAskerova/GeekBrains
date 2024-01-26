// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
}; 

void PrintArray(int[,] array)
    {
        //Напишите свое решение здесь
      for(int i = 0; i < array.GetLength(0); i ++)
      {
        for(int j = 0; j < array.GetLength(1); j ++)
        {
          Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
      }
    }

int[,] SwapFirstLastRows(int[,] array)
    {
        //Напишите свое решение здесь
      int tmp = 0;
      int lastrowindex = array.GetLength(0) - 1;
      
      for(int i = 0; i < array.GetLength(0); i++)
      {
        for(int j = 0; j < array.GetLength(1); j++)
        {
          tmp = array[0, j];
          array[0, j] = array[lastrowindex, j];
          array[lastrowindex, j] = tmp;
        }
      }
      return array;
    }

int[,] array = SwapFirstLastRows(numbers);
PrintArray(array);
