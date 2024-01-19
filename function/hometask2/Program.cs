// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


class Programm
{
    static void Main()
    {
        int[] array = new int[15];
        Random rnd = new Random();
        int evenCount = 0;
        for(int i = 0; i < 15; i++)
        {
            array[i] = rnd.Next(100, 1000);
            Console.Write(array[i] + " ");
        }
    
        foreach(int e in array)
        {
            if(e % 2 == 0)
            {
                evenCount = evenCount + 1;
            }
        }
        Console.Write($"\nКоличество четных элементов в массиве: {evenCount}");
    }
    
}


    




