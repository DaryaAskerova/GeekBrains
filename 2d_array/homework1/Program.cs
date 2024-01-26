// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] numbers = new int[,] {
    {1, 2, 3},
    {1, 1, 0},
    {7, 8, 2},
    {9, 10, 11}
};

/// Вычисление сумм по строкам (на выходе массив с суммами строк)
int[] SumRows(int[,] array)
{
    int rowCount = array.GetLength(0);
      
    int[] sums = new int[rowCount];
      
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
          rowSum = rowSum + array[i,j];
          
        }
         sums[i] = rowSum;
    }
    return sums;
     
}
    
// Получение индекса минимального элемента в одномерном массиве
int MinIndex(int[] array)
{
    int imin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < array[imin])
        {
          
          imin = i;
        }
    }
    return imin;
}
   
  
int[] sums = SumRows(numbers);
int index = MinIndex(sums);
Console.WriteLine(index);

