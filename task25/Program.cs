/*Задача 53: Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/
//функция получения положительного числа
int GetPositiveNumber(string text)
{
    int result = 0;
    Console.WriteLine(text);
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели число меньше 1");
        }
    }
    return result;
}
//функция получения числа
int GetNumber(string text)
{
    int result = 0;
    Console.WriteLine(text);
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}
//функция замены строк 
//функция печати 
//функция получения положительного числа
int GetPositiveNumber(string text)
{
    int result = 0;
    Console.WriteLine(text);
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели число меньше 1");
        }
    }
    return result;
}
//функция получения числа
int GetNumber(string text)
{
    int result = 0;
    Console.WriteLine(text);
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}
int m = GetPositiveNumber("Введите m");
int n = GetPositiveNumber("Введите n");
int minValue = GetNumber("Введите минимальное значение массива");
int maxValue = GetNumber("Введите максимальное значение массива");
int[,] array = GetArray(m, n, minValue, maxValue);
PrintArray(array);
int[,] resultArray = ArrayStringReplace(array);
Console.WriteLine();
PrintArray(resultArray);
От Yuriy всем 08:51 PM
//функция получения массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

