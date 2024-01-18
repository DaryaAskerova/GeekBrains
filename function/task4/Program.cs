// Задайте одномерный массив, заполненный случайными числами. Определите количество простых числел в этом массиве

// Создание массива
int[] CreateArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
    {
        
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}


//Поиск простых чисел
bool IsSimple(int n)
{
    for( int i = 2; i < n; i++)
    {
        if(n % i == 0)
        {
            return false;
        }
        
    }
    return true;
}

// Подсчет простых чисел
int GetPrimeQuantity(int[] array)
{
    int countPrimes = 0;
    foreach(int e in array)
    {
        bool result = IsSimple(e);
        if(result == true)
        {
            countPrimes = countPrimes + 1;
        }
        
    }
    return countPrimes;
}

Console.WriteLine("size");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(n);

int count = GetPrimeQuantity(arr);

Console.WriteLine(count);