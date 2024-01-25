// Создать двумерный массив с размером 3х5, состоящий из целых чисел. Вывести элементы на экран

int[,] CreateMatrix (int rowCount, int columCount)
{
    int[,] matrix = new int[3, 5];
    Random rnd = new Random();

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine(); // Переход на новую строку, чтобы массив вышел в виде таблицы
    }

}

int[,] matrix = CreateMatrix(3,5);
PrintMatrix(matrix);