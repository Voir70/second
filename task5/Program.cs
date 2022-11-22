/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

int number = Int32.Parse(Console.ReadLine());
if (number > 999 && number < 100)
{
    Console.WriteLine("wrong number");
return;
}    
int number2 = number % 10;  // если днаписать % 100 то покажет два последних числа
Console.WriteLine(number2);

