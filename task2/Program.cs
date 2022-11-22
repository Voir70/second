/* Напишите программу,которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a =25, b = 5 -> да
a =2, b = 10 -> нет
a =9, b = -3 -> да
a =-3, b = 9 -> нет
*/


Console.WriteLine("Введите число №1");
string numberfirst = Console.ReadLine();
int number1 = Convert.ToInt32(numberfirst);

Console.WriteLine("Введите число №2");
string numbersecond = Console.ReadLine();
int number2 = Convert.ToInt32(numbersecond);

if(number1 / number2 == number2)
{
Console.WriteLine("Является");
} else {
Console.WriteLine(" Не является");
}
