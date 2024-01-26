// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет: "Позиция по рядам выходит за пределы массива" или "Позиция по колонкам выходит за пределы массива". Позиции в массиве считать от единицы.

int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};

int x = 2;
int y = 2;

// Поиск элемента по позициям
int FindElementByPosition(int[,] array, int x, int y)
    {
        //Напишите свое решение здесь
      int irow = x - 1;
      int icolum = y - 1;
      int elem = 0;
      
      for(int i = 0; i < array.GetLength(0); i ++)
      {
        for(int j = 0; j < array.GetLength(1); j ++)
        {
          elem = array[irow, icolum];
        }
      }
      return elem;
      
    }

// Проверка позиций на вхождение в массив
bool ValidatePosition(int[,] array, int x, int y)
    {
        //Напишите свое решение здесь
      int rowCount = array.GetLength(0);
      int columCount = array.GetLength(1);
      
      if(x - 1 <= rowCount)
      {
        if(y - 1 <= columCount)
        {
          return true;
        }
        else
        {
          Console.Write("Позиция по колонкам выходит за пределы массива");
          return false;
          
        }
      }
      else
      {
        Console.Write("Позиция по рядам выходит за пределы массива");
        return false;
        
      }
    }

ValidatePosition(numbers, x, y);
int result = FindElementByPosition(numbers, x, y);
Console.Write(result);
