// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

int[] numbers = { 10, 9, 7, 45, 25, 3 };
int temp;

Console.Write("Исходный массив: ");
foreach(int number in numbers)
{
    Console.Write(number + " ");
}

for(int i = 0; i < 6; i++)
{
    temp = numbers[i];
    numbers[i] = numbers[6 - 1 - i];
    numbers[6 - 1 - i] = temp;
}
Console.Write("Перевернутый массив: ");
foreach(int number in numbers)
{
    Console.Write(number + " ");
}