// Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.


string GetLettersLowercase(char[] array)
{
    string str = "";
    foreach(char e in array)
    {
        str += e;
    }
    str = str.ToLower();
    return str;
}

char[] chars = {'H', 'E', 'L', 'L', 'O'};
string str = GetLettersLowercase(chars);
Console.WriteLine(str);
