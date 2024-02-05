// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. В материалах урока можно найти изображение с описанием функции.
int AccermanFunction(int n, int m)
    {
        if (n == 0)
        {
            return m + 1;
        }
        if (m == 0)
        {
             return AccermanFunction(n - 1, 1);
        }
        return AccermanFunction(n - 1, AccermanFunction(n, m - 1));
    }

Console.WriteLine(AccermanFunction(2, 3));



