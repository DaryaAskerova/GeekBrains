// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

string GetStringFromCharArray(char[] array)
{
    string str = "";
    foreach(char e in array)
    {
        str += e;
    }
    return str;
}

char[] chars = {'H', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd'};
string str = GetStringFromCharArray(chars);
Console.WriteLine(str);
