/*Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до 
4 -> " -4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2" */

Console.WriteLine("Введите число ");
string numberFirst = Console.ReadLine();      // а можно две строчки в одной уместить string numberFirst = Convert.ToInt32(Console.ReadLine());
int number = Convert.ToInt32(numberFirst);

number = Math.Abs(number);
for (int i = -number; i <= number; i++)
    Console.Write($"{i},");
