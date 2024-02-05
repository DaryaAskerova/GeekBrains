// Создайте массив символов (тип char[]). Создайте строку из символов этого массива.
string GetStringFromCharArray(char[] array)
{
    string str = "";
    foreach(char e in array)
    {
        str += e;
    }
    return str;
}

char[] chars = {'a', 'b', 'c', 'd'};
string str = GetStringFromCharArray(chars);
Console.WriteLine(str);

