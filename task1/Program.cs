/*
Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя)

Например:
4 -> 16
-3 -> 9
-7 -> 49

то что мы вводим с консоли, всегда будет тип string

234 - "234"
*/

// int, Int32 - это числа от -2147483647 до 2147483647
// long, Int64 - это числа от -9223372036854775807 до 9223372036854775807

//Варианты написания строк кода Console.WriteLine("Квадрат числа" + number + " = " + result);
                              //Console.WriteLine($"Квадрат числа {0} = {1}", number, result);
                              //Console.WriteLine($"Квадрат числа {number} = {result}");

Console.WriteLine("введите число");
string numberStr = Console.ReadLine() ?? string.Empty;
int number = Convert.ToInt32(numberStr); 

int result = number * number;

Console.WriteLine($"Квадрат числа {number} = {result}");

//string numberStr = Console.ReadLine() ?? string.Empty; эта запись равна этой string t = Console.Readline();
                                                                             //if(t == nul)
                                                                             //{
                                                                                  //T = ""
                                                                             //}


//А можно решить в два действия эту задачу
//Console.WriteLine("введите число");
//Console.WriteLine($"Квадрат = {Math.Pow(int.Parse(Console.ReadLine()),2)}");
45