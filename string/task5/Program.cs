// На основе символов строки (типа string) сформировать массив симыолов (тиа char[]). Вывести массив на экран
char[] StringToCharArray(string str)
{
    char[] chars = new char[str.Length];
    for(int i = 0; i < str.Length; i++)
    {
        chars[i] = str[i];
    }
    return chars;
}

string str = "Hello world!";
char[] chars = StringToCharArray(str);
foreach(char e in chars)
{
    Console.WriteLine(e);
}