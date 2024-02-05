// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
void PrintNumber(int M, int N)
{
    if(M == N)
    {
        Console.WriteLine("Stop");
        return;
    }
    
    Console.Write($"{M} ");
    PrintNumber(M + 1, N);
}

PrintNumber(2, 10);
