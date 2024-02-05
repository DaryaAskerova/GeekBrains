// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
void ReversArray (int[] array, int arr)
{
    if(arr > array.Length)
    {
        Console.WriteLine("Stop");
        return;
    }
    ReversArray (array, arr + 1);
    Console.Write($"{arr} ");

}
int[] array = {1, 2, 3, 4, 5, 6, 7};
ReversArray (array, 1);
